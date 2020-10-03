using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4WithGUI
{
	static class Program
	{
		public static SerialPort SerialPort { get; set; } = new SerialPort();
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				if (!initSerialPort())
					return;
				Application.Run(new Form1());
			}
			finally
			{
				SerialPort.Close();
			}
		}
		
		static bool initSerialPort()
		{
			SerialPort.BaudRate = 9600;
			var portDlg = new PortDialog();
			while (DialogResult.OK == portDlg.ShowDialog())
			{
				SerialPort.PortName = portDlg.PortName;
				SerialPort.BaudRate = 9600;
				try
				{
					SerialPort.Open();
					return true;
				}
				catch (IOException ex)
				{
					MessageBox.Show(ex.Message);
				}
				catch (UnauthorizedAccessException ex)
				{
					MessageBox.Show(ex.Message + "\nClose the serial monitor darn it!");
				}
			}
			return false; //The user closed the window without clicking Ok.
		}
	}
}
