using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4WithGUI
{
	public struct ActionStep
	{
		public string Name { get; set; }
		public float Time { get; set; }
		public Color Color { get; set; }
		public bool Fade { get; set; }
	}
}
