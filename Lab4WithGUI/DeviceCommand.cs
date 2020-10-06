using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4WithGUI
{
	class DeviceCommand
	{
		//A random string that (probably) uniquely identifies this command
		//Limit to 4 bytes to reduce uart transfer time and memory usage on device
		readonly string guid = Guid.NewGuid().ToString().Substring(0, 4);
		public DeviceStatus DeviceStatus { get; set; }
		uint delay;
		bool recurring;
		bool active;

		//public string Description { get; set; }
		public uint Delay
		{
			get => delay;
			set
			{
				delay = value;
				send();
			}
		}
		public bool Recurring
		{
			get => recurring;
			set
			{
				recurring = value;
				send();
			}
		}

		public bool Active
		{
			get => active;
			set
			{
				active = value;
				send();
			}
		}

		string stateCommandString => $"s{(char)DeviceStatus.State}{(char)DeviceStatus.SubState}";
		string speedCommandString
		{
			get
			{
				string command;
				if (DeviceStatus.State == 0 && DeviceStatus.SubState == 1)
					command = "b";  //Command for changing blink speed
				else if (DeviceStatus.State == 1)
					command = "f";  //Command for Changing fade speed
				else
					return "";
				return command + (char)DeviceStatus.Speed;
			}
		}
		string colorCommandString => $"c{(char)DeviceStatus.Color.R}{(char)DeviceStatus.Color.G}{(char)DeviceStatus.Color.B}";
		
		public void sendState()
		{
			sendCommand(stateCommandString);
		}
		public void sendSpeed()
		{
			sendCommand(speedCommandString);
		}

		public void sendColor()
		{
			sendCommand(colorCommandString);
		}

		//Sends specified command to device.
		//Adds ! to start and # to end of message
		private void sendCommand(string command)
		{
			if (!active)
				return;
			//Since we are sending binary data it seems we need to send a byte array,
			//because sending a string will mess up bytes with values > 127
			List<byte> bytes = new List<byte>();
			bytes.Add((byte)'!');
			for (int i = 0; i < guid.Length; i++)
				bytes.Add((byte)guid[i]);
			bytes.Add((byte)(Delay & 0xff));
			bytes.Add((byte)((Delay >> 8) & 0xff));
			bytes.Add((byte)((Delay >> 16) & 0xff));
			bytes.Add((byte)((Delay >> 24) & 0xff));
			bytes.Add((byte)(recurring ? 1 : 0));
			for (int i = 0; i < command.Length; i++)
				bytes.Add((byte)command[i]);
			bytes.Add((byte)'#');

			lock (Uart.Lock)
				Uart.Port.Write(bytes.ToArray(), 0, bytes.Count);
		}

		void send()
		{
			sendCommand(stateCommandString + speedCommandString + colorCommandString);
		}
	}
}
