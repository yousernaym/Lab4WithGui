﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
		//DeviceStatus deviceStatus = new DeviceStatus();
		//int state => singleColorRb.Checked ? 0 : 1;
		//int subState => constantRb.Checked ? 0 : 1;
		//byte speed => (byte)speedTrackbar.Value;
		//Color color => colorBtn.BackColor;
		
		List<DeviceStatus> deviceCommands = new List<DeviceStatus>();
		DeviceStatus selectedCommand
		{
			get
			{
				if (commandsDgv.CurrentRow == null)
					return null;
				else
					return deviceCommands[commandsDgv.CurrentRow.Index];
			}
		}

		DeviceStatus currentDeviceStatus = new DeviceStatus();

		//Listening for incoming uart data
		readonly Thread uartListener;

		public Form1()
		{
			InitializeComponent();
			AllocConsole();
			uartListener = new Thread(new ThreadStart(readUartCommands));
			uartListener.Start();

			//Init device to default status
			currentDeviceStatus.setStatus(0, 0, colorBtn.BackColor, 128);
			currentDeviceStatus.send();

		}

		//Enables debug output
		//Source: https://stackoverflow.com/questions/4362111/how-do-i-show-a-console-output-window-in-a-forms-application
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		//Switches to single-color state
		private void singleColorRb_Click(object sender, EventArgs e)
		{
			setStatus(0, -1, null, -1);
		}
	

		//Switches to rainbow state
		private void rainbowRb_Click(object sender, EventArgs e)
		{
			setStatus(1, -1, null, -1);
		}

		//Switches to constant (non-blinking) substate
		private void constantRb_Click(object sender, EventArgs e)
		{
			setStatus(-1, 0, null, -1);
		}

		//Switches to blinking substate
		private void blinkRb_Click(object sender, EventArgs e)
		{
			setStatus(-1, 1, null, -1);
		}

		//Opens a ColorPicker to select color for single-color state
		private void colorBtn_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == colorDialog1.ShowDialog())
			{
				setStatus(-1, -1, colorBtn.BackColor = colorDialog1.Color, -1);
			}
		}

		//Blink/fade speed changed
		private void speedTrackbar_Scroll(object sender, EventArgs e)
		{
			setStatus(-1, -1, null, speedTrackbar.Value);
		}

		private void setStatus(int state, int subState, Color ?color, int speed)
		{
			if (commandsDgv.SelectedRows.Count == 0)
			{
				currentDeviceStatus.setStatus(state, subState, color, speed);
				currentDeviceStatus.send();
			}
			else
			{
				foreach (DataGridViewRow row in commandsDgv.SelectedRows)
				{
					deviceCommands[row.Index].setStatus(state, subState, color, speed);
					if (deviceCommands[row.Index].Scheduled)
						deviceCommands[row.Index].send();
				}
			}
		}

		//Listens for messages from device and updates GUI accordingly.
		//Runs on background thread
		private void readUartCommands()
		{
			string commandBuf = "";
			const int BufSize = 50;

			while (true)
			{
				int readByte = -1;
				lock (Uart.Lock)
				{
					if (Uart.Port.BytesToRead > 0)
					{
						readByte = Uart.Port.ReadByte();
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
						string statusCommandBuf = commandBuf;
						int commandSize = 0;
						while ((commandSize = readStatusCommand(statusCommandBuf)) > 0)
							statusCommandBuf = statusCommandBuf.Substring(commandSize);
						Invoke(new Action(() => updateGui()));
					}
					else
					{
						commandBuf += c.ToString();
					}
				}
			}
		}

		private int readStatusCommand(string buf)
		{
			if (buf.Length == 0)
				return 0;
			char command = buf[0];
			int commandSize = 0;
			if (command == 's') //Set state
			{
				currentDeviceStatus.State = buf[1];
				currentDeviceStatus.SubState = buf[2];
				commandSize = 3;
			}
			else if (command == 'c') //Set color
			{
				currentDeviceStatus.Color = Color.FromArgb((byte)buf[1], (byte)buf[2], (byte)buf[3]);
				commandSize = 4;
			}
			else if (command == 's') //Set fade/blink speed
			{
				currentDeviceStatus.Speed = (byte)buf[1];
				commandSize = 2;
			}
			return commandSize;
		}

		//updates radio buttons
		private void setGuiState(int state, int subState)
		{
			if (state == 0)
				singleColorRb.Checked = true;
			else if (state == 1)
				rainbowRb.Checked = true;
			if (subState == 0)
				constantRb.Checked = true;
			else if (subState == 1)
				blinkRb.Checked = true;
		}

		//Updates color controls
		private void setGuiColor(byte r, byte g, byte b)
		{
			colorBtn.Invoke(new Action(() => colorBtn.BackColor = Color.FromArgb(r, g, b)));
		}

		//Update speed fader
		private void setGuiSpeed(byte speed)
		{
			speedTrackbar.Value = speed;
		}

		//Closes uart listening thread when app is closing
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			uartListener.Abort();
		}

		private void singleColorRb_CheckedChanged(object sender, EventArgs e)
		{
			updateGuiAccess();
		}

		private void constantRb_CheckedChanged(object sender, EventArgs e)
		{
			updateGuiAccess();
		}

		//Enable/disable controls depending on state
		private void updateGuiAccess()
		{
			singleColorPanel.Enabled = singleColorRb.Checked;
			speedPanel.Enabled = blinkRb.Checked && singleColorRb.Checked || !singleColorRb.Checked;
		}

		//Update color of ColorPicker when color of color selection button changes
		private void colorBtn_BackColorChanged(object sender, EventArgs e)
		{
			colorDialog1.Color = colorBtn.BackColor;
		}

		private void commandsDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			DataGridViewRow row = commandsDgv.Rows[e.RowIndex];
			var status = new DeviceStatus()
			{
				Delay = getCommandCellUint(row, 1),
				Rerun = getCommandCellBool(row, 1),
				Scheduled = getCommandCellBool(row, 1),
				State = currentDeviceStatus.State,
				SubState = currentDeviceStatus.SubState,
				Color = currentDeviceStatus.Color,
				Speed = currentDeviceStatus.Speed
			};
			deviceCommands.Add(status);
		}

		uint getCommandCellUint(DataGridViewRow row, int colIndex)
		{
			var value = row.Cells[colIndex].Value;
			if (value != null)
				return uint.Parse((string)value);
			else
				return 0;
		}

		bool getCommandCellBool(DataGridViewRow row, int colIndex)
		{
			var value = row.Cells[colIndex].Value;
			if (value != null)
				return (bool)value;
			else
				return false;
		}

		//Check that delay time is entered as a positive integer
		//Source: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcellvalidatingeventargs.formattedvalue?view=netframework-4.8&f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(System.Windows.Forms.DataGridViewCellValidatingEventArgs.FormattedValue);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv4.8);k(DevLang-csharp)%26rd%3Dtrue
		private void commandsDgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				commandsDgv.Rows[e.RowIndex].ErrorText = "";
				int newInteger;

				// Don't try to validate the 'new row' until finished 
				// editing since there
				// is not any point in validating its initial value.
				if (commandsDgv.Rows[e.RowIndex].IsNewRow) { return; }
				if (!int.TryParse(e.FormattedValue.ToString(),
					out newInteger) || newInteger < 0)
				{
					e.Cancel = true;
					commandsDgv.Rows[e.RowIndex].ErrorText = "The value must be a non-negative integer";
				}
			}
		}

		private void commandsDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			var row = commandsDgv.Rows[e.RowIndex];
			int col = e.ColumnIndex;
			if (col == 1) //Delay
				deviceCommands[e.RowIndex].Delay = getCommandCellUint(row, 1);
			else if (col == 2)  //Rerun
				deviceCommands[e.RowIndex].Rerun = getCommandCellBool(row, 2);
			else if (col == 3) //Scheduled
				deviceCommands[e.RowIndex].Scheduled = getCommandCellBool(row, 3);
			if (deviceCommands[e.RowIndex].Scheduled)
				deviceCommands[e.RowIndex].send();
		}

		private void commandsDgv_SelectionChanged(object sender, EventArgs e)
		{
			updateGui();
		}

		private void updateGui()
		{
			if (commandsDgv.SelectedRows.Count == 0)
				updateGui(currentDeviceStatus);
			else
				updateGui(deviceCommands[commandsDgv.SelectedRows[0].Index]);
		}

		private void updateGui(DeviceStatus deviceStatus)
		{
			setGuiState(deviceStatus.State, deviceStatus.SubState);
			setGuiColor(deviceStatus.Color.R, deviceStatus.Color.G, deviceStatus.Color.B);
			setGuiSpeed(deviceStatus.Speed);
		}
	}
}
