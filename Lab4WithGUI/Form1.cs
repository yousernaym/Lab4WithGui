using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4WithGUI
{
	public partial class Form1 : Form
	{
		//Gets current state
		int state => singleColorRb.Checked ? 0 : 1;
		int subState => constantRb.Checked ? 0 : 1;

		//Protects serial port from concurrent access from different threads
		readonly object serialPortLock = new object(); 
		
		//Listening for incoming uart data
		readonly Thread uartListener;
		
		//Used for uart communication
		SerialPort serialPort => Program.SerialPort;
		
		public Form1()
		{
			InitializeComponent();
			AllocConsole();
			uartListener = new Thread(new ThreadStart(readUartCommands));
			uartListener.Start();
			
			//Init device so that it matches app
			singleColorRb.PerformClick();
			constantRb.PerformClick();
			setColor(colorBtn.BackColor = Color.Lime);
		}

		//Enable debug output
		//Source: https://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		//Sets state of device
		private void setState(uint time, int state, int subState)
		{
			sendCommand(time, $"s{(char)state}{(char)subState}");
		}

		//Sets color of single-color state
		private void setColor(Color c)
		{
			sendCommand(0, $"c{(char)c.R}{(char)c.G}{(char)c.B}");
		}

		//Sends specified command to device.
		//Adds ! to start and # to end of message
		//<time> specifies how many seconds the device should wait before executing the command
		private void sendCommand(uint time, string command)
		{
			//Since we are sending binary data we need to send a byte array,
			//because sending a string will mess up bytes with values > 127
			List<byte> bytes = new List<byte>();
			bytes.Add((byte)'!');
			bytes.Add((byte)(time & 0xff));
			bytes.Add((byte)((time >> 8) & 0xff));
			bytes.Add((byte)((time >> 16) & 0xff));
			bytes.Add((byte)((time >> 24) & 0xff));
			for (int i = 0; i < command.Length; i++)
				bytes.Add((byte)command[i]);
			bytes.Add ((byte)'#');
			
			lock (serialPortLock)
				serialPort.Write(bytes.ToArray(), 0, bytes.Count);
		}

		//Opens a ColorPicker to select color for single-color state
		private void colorBtn_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == colorDialog1.ShowDialog())
				setColor(colorBtn.BackColor = colorDialog1.Color);
		}

		//Switches to single-color state
		private void singleColorRb_Click(object sender, EventArgs e)
		{
			setState(0, 0, constantRb.Checked ? 0 : 1);
		}

		//Switches to rainbow state
		private void rainbowRb_Click(object sender, EventArgs e)
		{
			setState(0, 1, 0);
		}

		//Switches to constant (non-blinking) substate
		private void constantRb_Click(object sender, EventArgs e)
		{
			setState(0, 0, 0);
		}

		//Switches to blinking substate
		private void blinkRb_Click(object sender, EventArgs e)
		{
			setState(0, 0, 1);
		}

		//Listens for messages from device and updates GUI to reflect device status
		//Runs on background thread
		private void readUartCommands()
		{
			string commandBuf = "";
			const int BufSize = 50;

			while (true)
			{
				int readByte = -1;
				lock (serialPortLock)
				{
					if (serialPort.BytesToRead > 0)
					{
						//Console.WriteLine(serialPort.ReadExisting()); ;
						readByte = serialPort.ReadByte();
					}
				}
				
				if (readByte >= 0)
				{
					char c = (char)readByte;
					if (c == '!')  //Start of a new message
						commandBuf = "";
					else if (c == '#' || commandBuf.Length == BufSize) //End of message, or message too long
					{
						//Parse message

						//First byte = type of command
						char command = commandBuf[0];
						if (command == 's') //Set state
						{
							char state = commandBuf[1];
							char subState = commandBuf[2];
							setGuiState(state, subState);
						}
						else if (command == 'c') //Set color
						{
							int color = commandBuf[1] | (commandBuf[2] << 8) | (commandBuf[3] << 16);
							setGuiColor(color);
						}
					}
					else
					{
						commandBuf += c.ToString();
					}
				}
			}
		}

		//updates radio buttons in response to buttons on device
		//Since this method is called from the background thread it needs to invoke the updates on UI thread
		private void setGuiState(char state, char subState)
		{
			if (state == 0)
				singleColorRb.Invoke(new Action(() => singleColorRb.Checked = true));
			else if (state == 1)
				singleColorRb.Invoke(new Action(() => rainbowRb.Checked = true));
			if (subState == 0)
				constantRb.Invoke(new Action(() => constantRb.Checked = true));
			else if (subState == 1)
				blinkRb.Invoke(new Action(() => blinkRb.Checked = true));
		}

		//Updates color of color selection button in app in response to color selection button on device
		private void setGuiColor(int color)
		{
			Color c = Color.FromArgb(color & 0xff, (color >> 8) & 0xff, (color >> 16) & 0xff);
			colorBtn.Invoke(new Action(() => colorBtn.BackColor = c));
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			uartListener.Abort();
		}

		//Updates which controls are enabled when main state changes
		private void singleColorRb_CheckedChanged(object sender, EventArgs e)
		{
			singleColorPanel.Enabled = singleColorRb.Checked;
			speedPanel.Enabled = blinkRb.Checked && singleColorRb.Checked || !singleColorRb.Checked;
		}

		//Enables/disables speed control when enabling/disabling blinking
		private void constantRb_CheckedChanged(object sender, EventArgs e)
		{
			speedPanel.Enabled = !constantRb.Checked;
		}

		//Blink/Fade speed changed
		private void speedTrackbar_Scroll(object sender, EventArgs e)
		{
			string command;
			if (state == 0 && subState == 1) 
				command = "b";  //Command for changing blink speed
			else if (state == 1)
				command = "f";  //Command for Changing fade speed
			else
				return;
			sendCommand(0, command + (char)speedTrackbar.Value);
		}

		//Update color of ColorPicker when color of color selection button changes
		private void colorBtn_BackColorChanged(object sender, EventArgs e)
		{
			colorDialog1.Color = colorBtn.BackColor;
		}
	}
}
