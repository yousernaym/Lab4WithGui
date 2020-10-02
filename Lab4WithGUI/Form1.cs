using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4WithGUI
{
	public partial class Form1 : Form
	{
		SerialPort serialPort => Program.SerialPort;
		public Form1()
		{
			InitializeComponent();
		}

		private void setState(uint time, char state, char subState)
		{
			sendCommand(time, $"s{state}{subState}");
		}

		//Sends specified command to device.
		//Device stores command <time> seconds before executing it.
		//Commands always start with ! and end with \n
		private void sendCommand(uint time, string command)
		{
			string serializedTime = $"{(char)time}{(char)(time >> 8)}{(char)(time >> 16)}{(char)(time >> 24)}";
			string message = $"!{serializedTime}{command}\n";
			serialPort.Write(message);
		}

		private void colorBtn_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == colorDialog1.ShowDialog())
			{
				Color c = colorBtn.BackColor = colorDialog1.Color;
				sendCommand(0, $"c{(char)c.R}{(char)c.G}{(char)c.B}");
			}
		}

		private void singleColorRb_Click(object sender, EventArgs e)
		{
			singleColorPanel.Enabled = true;
			speedPanel.Enabled = blinkRb.Checked;
			setState(0, (char)0, (char)(constantRb.Checked ? 0 : 1));
		}

		private void rainbowRb_Click(object sender, EventArgs e)
		{
			singleColorPanel.Enabled = false;
			speedPanel.Enabled = true;
			setState(0, (char)1, (char)0);
		}

		private void constantRb_Click(object sender, EventArgs e)
		{
			speedPanel.Enabled = false;
			setState(0, (char)0, (char)0);
		}

		private void blinkRb_Click(object sender, EventArgs e)
		{
			speedPanel.Enabled = true;
			setState(0, (char)0, (char)1);
		}


	}
}
