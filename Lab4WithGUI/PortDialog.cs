using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4WithGUI
{
	public partial class PortDialog : Form
	{
		public string PortName => portTb.Text;
		public PortDialog()
		{
			InitializeComponent();
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
