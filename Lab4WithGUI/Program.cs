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
				//Close app if user doesn't connect to serial port
				if (!connectToDevice())
					return;
				Application.Run(new Form1());
			}
			finally
			{
				Uart.disconnect();
			}
		}
		
		static bool connectToDevice()
		{
			var portDlg = new PortDialog();
			
			//Loop until a successful connection is made or the user gives up
			while (DialogResult.OK == portDlg.ShowDialog())
			{
				try
				{
					Uart.connect(portDlg.PortName);
					return true;
				}
				catch (UnauthorizedAccessException ex)
				{
					MessageBox.Show(ex.Message + "\nClose the serial monitor darn it!");
				}
				catch (Exception ex) when (ex is IOException || ex is ArgumentException)
				{
					MessageBox.Show(ex.Message);
				}
			}
			return false;
		}
	}
}
