using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4WithGUI
{
	static public class Uart
	{
		//Protects serial port from concurrent access from different threads
		public static readonly object Lock = new object();

		//Port for communication
		static SerialPort serialPort = new SerialPort();
		public static SerialPort Port => serialPort;

		public static void connect(string portName)
		{
			serialPort.PortName = portName;
			serialPort.BaudRate = 9600;
			serialPort.Open();
		}

		public static void disconnect()
		{
			serialPort.Close();
		}
	}
}
