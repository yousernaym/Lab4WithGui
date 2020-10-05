using System;
using System.Drawing;
using System.Net.Mail;

namespace Lab4WithGUI
{
	public class DeviceStatus
	{
		private int state;
		private int subState;
		private byte speed;
		private Color color;

		public int State
		{
			get => state;
			set
			{
				state = value;
				
			}
		}
		public int SubState { get => subState; set => subState = value; }
		public byte Speed { get => speed; set => speed = value; }
		public Color Color { get => color; set => color = value; }

		internal void updateDevice()
		{
			throw new NotImplementedException();
		}

		void sendState()
		{
			
		}

		void sendSpeed()
		{

		}

		void sendColor()
		{

		}

		
	}
}