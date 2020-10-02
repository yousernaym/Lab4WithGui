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
	public partial class Form1 : Form
	{
		List<Action> actions = new List<Action>();
		public Form1()
		{
			InitializeComponent();
		}

		private void rainbowRb_CheckedChanged(object sender, EventArgs e)
		{
			singleColorPanel.Enabled = false;
			speedPanel.Enabled = true;
		}

		private void constantRb_CheckedChanged(object sender, EventArgs e)
		{
			speedPanel.Enabled = false;
		}

		private void blinkRb_CheckedChanged(object sender, EventArgs e)
		{
			speedPanel.Enabled = true;
		}

		private void colorBtn_Click(object sender, EventArgs e)
		{

		}

		private void singleColorRb_CheckedChanged(object sender, EventArgs e)
		{
			singleColorPanel.Enabled = true;
			speedPanel.Enabled = blinkRb.Checked;
		}
	}
}
