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
	public partial class ActionStepDialog : Form
	{
		ActionStep step = new ActionStep();
		public ActionStep Step
		{
			get => step;
			set
			{
				nameTb.Text = value.Name;
				timeUd.Value = (decimal)value.Time;
				colorBtn.BackColor = value.Color;
				fadeCb.Checked = value.Fade;
			}
		}
		public ActionStepDialog()
		{
			InitializeComponent();
		}

		private void colorBtn_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == colorDialog1.ShowDialog())
				colorBtn.BackColor = step.Color = colorDialog1.Color;
			}

		private void nameTb_TextChanged(object sender, EventArgs e)
		{
			step.Name = nameTb.Text;
		}

		private void timeUd_ValueChanged(object sender, EventArgs e)
		{
			step.Time = (float)timeUd.Value;
		}

		private void fadeCb_CheckedChanged(object sender, EventArgs e)
		{
			step.Fade = fadeCb.Checked;
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameTb.Text))
			{
				MessageBox.Show("Name field cannot be empty");
				return;
			}
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
