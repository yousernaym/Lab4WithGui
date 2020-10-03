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
			uartListener = new Thread(new ThreadStart(readUartCommand));
			uartListener.Start();
		}

		//Enable debug output
		//Source: https://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		//Sets state of device
		private void setState(uint time, char state, char subState)
		{
			sendCommand(time, $"s{state}{subState}");
		}

		//Sends specified command to device.
		//Adds ! to start and # to end of message
		//<time> specifies how many seconds the device should wait before executing the command
		private void sendCommand(uint time, string command)
		{
			string serializedTime = $"{(char)time}{(char)(time >> 8)}{(char)(time >> 16)}{(char)(time >> 24)}";
			string message = $"!{serializedTime}{command}#";
			lock (serialPortLock)
				serialPort.Write(message);
		}

		//Selects color for single-color state
		private void colorBtn_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == colorDialog1.ShowDialog())
			{
				Color c = colorBtn.BackColor = colorDialog1.Color;
				sendCommand(0, $"c{(char)c.R}{(char)c.G}{(char)c.B}");
			}
		}

		//Switches to single-color state
		private void singleColorRb_Click(object sender, EventArgs e)
		{
			setState(0, (char)0, (char)(constantRb.Checked ? 0 : 1));
		}

		//Switches to rainbow state
		private void rainbowRb_Click(object sender, EventArgs e)
		{
			setState(0, (char)1, (char)0);
		}

		//Switches to constant (non-blinking) substate
		private void constantRb_Click(object sender, EventArgs e)
		{
			setState(0, (char)0, (char)0);
		}

		//Switches to blinking substate
		private void blinkRb_Click(object sender, EventArgs e)
		{
			setState(0, (char)0, (char)1);
		}

		//Listens for messages from device and updates GUI to reflect device status
		//Runs on background thread
		private void readUartCommand()
		{
			string commandBuf = "";
			const int BufSize = 50;

			while (true)
			{
				int readByte = -1;
				lock (serialPortLock)
				{
					//App closes port on shutdown in main thread so check if still open
					if (serialPort.IsOpen && serialPort.BytesToRead > 0)
						readByte = serialPort.ReadByte();
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

		private void setGuiColor(int color)
		{
		
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		//Updates which controls are enabled when main state changes
		private void singleColorRb_CheckedChanged(object sender, EventArgs e)
		{
			singleColorPanel.Enabled = singleColorRb.Checked;
			speedPanel.Enabled = blinkRb.Checked && singleColorRb.Checked || !singleColorRb.Checked;
		}

		//Updates which controls are enabled when single-color substate changes
		private void constantRb_CheckedChanged(object sender, EventArgs e)
		{
			speedPanel.Enabled = !constantRb.Checked;
		}
	}
}
