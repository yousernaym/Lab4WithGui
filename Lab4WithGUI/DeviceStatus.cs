using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4WithGUI
{
	class DeviceStatus
	{
		//A random string that (probably) uniquely identifies this command
		//Limit to 4 bytes to reduce uart transfer time and memory usage on device
		readonly string scheduleId = Guid.NewGuid().ToString().Substring(0, 4);
		public string ScheduleId => scheduleId;
		public uint Delay { get; set; }
		public bool Rerun { get; set; }
		public bool Scheduled { get; set; }
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
			string message = "!" + scheduleId +
				(char)(Delay & 0xff) +
				(char)((Delay >> 8) & 0xff) +
				(char)((Delay >> 16) & 0xff) +
				(char)((Delay >> 24) & 0xff) +
				(char)(Rerun ? 1 : 0) +
				command + "#";

			lock (Uart.Lock)
				Uart.Port.Write(stringToBytes(message), 0, message.Length);
		}

		private byte[] stringToBytes(string message)
		{
			//Since we are sending binary data to the device it seems we must convert to a byte array,
			//because sending a string will mess up bytes with values > 127
			//Using the Encoding class to do the conversion doisn't work either so I convert manually
			var bytes = new List<byte>();
			foreach (var c in message)
				bytes.Add((byte)c);
			return bytes.ToArray();
		}

		public void send()
		{
			sendCommand(stateCommandString + speedCommandString + colorCommandString);
		}

		public void setStatus(int state, int subState, Color? color, int speed)
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

		internal void removeScheduling()
		{
			string message = $"!{scheduleId}r#";
			lock (Uart.Lock)
				Uart.Port.Write(stringToBytes(message), 0, message.Length);
		}
	}
}
