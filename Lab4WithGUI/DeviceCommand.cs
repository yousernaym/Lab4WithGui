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
		//public DeviceStatus DeviceStatus { get; set; }
		uint delay;
		bool recurring;
		bool scheduled;

		//public string Description { get; set; }
		public uint Delay
		{
			get => delay;
			set
			{
				delay = value;
				//send();
			}
		}
		public bool Recurring
		{
			get => recurring;
			set
			{
				recurring = value;
				//send();
			}
		}

		public bool Scheduled
		{
			get => scheduled;
			set
			{
				scheduled = value;
			}
		}

		public int State { get; set; }
		public int SubState { get; set; }
		public byte Speed { get; set; }
		public Color Color { get; set; }

		string stateCommandString => $"s{(char)State}{(char)SubState}";
		string speedCommandString
		{
			get
			{
				string command;
				if (State == 0 && SubState == 1)
					command = "b";  //Command for changing blink speed
				else if (State == 1)
					command = "f";  //Command for Changing fade speed
				else
					return "";
				return command + (char)Speed;
			}
		}
		string colorCommandString => $"c{(char)Color.R}{(char)Color.G}{(char)Color.B}";
		
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

		public void send()
		{
			sendCommand(stateCommandString + speedCommandString + colorCommandString);
		}

		public void setStatus(int state, int subState, Color ?color, int speed)
		{
			if (state >= 0)
				State = state;
			if (subState >= 0)
				SubState = subState;
			if (color != null)
				Color = (Color)color;
			if (speed >= 0)
				Speed = (byte)speed;
		}
	}
}
