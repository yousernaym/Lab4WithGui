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
		SerialPort serialPort = new SerialPort();
		public Form1()
		{
			InitializeComponent();
			var portDlg = new PortDialog();
			if (DialogResult.OK == portDlg.ShowDialog())
				return;
			serialPort.PortName = portDlg.PortName;
			serialPort.BaudRate = 9600;
			try
			{
				serialPort.Open();
			}
			catch (IOException)
			{
				MessageBox.Show("Couldn't connect");
			}
		}

		private void activateState(char state, char subState)
		{
			string command = $"!{state}{subState}\n";
			serialPort.Write(command);
		}

		private void colorBtn_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == colorDialog1.ShowDialog())
				colorBtn.BackColor = colorDialog1.Color;
		}

		
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			serialPort.Close();
		}

		private void singleColorRb_Click(object sender, EventArgs e)
		{
			singleColorPanel.Enabled = true;
			speedPanel.Enabled = blinkRb.Checked;
			activateState((char)0, (char)(constantRb.Checked ? 0 : 1));
		}
		private void rainbowRb_Click(object sender, EventArgs e)
		{
			singleColorPanel.Enabled = false;
			speedPanel.Enabled = true;
			activateState((char)1, (char)0);
		}

		private void constantRb_Click(object sender, EventArgs e)
		{
			speedPanel.Enabled = false;
			activateState((char)0, (char)0);
		}

		private void blinkRb_Click(object sender, EventArgs e)
		{
			speedPanel.Enabled = true;
			activateState((char)0, (char)1);
		}


	}
}
