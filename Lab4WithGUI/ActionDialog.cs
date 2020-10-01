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
	public partial class ActionDialog : Form
	{
		Action action = new Action();
		public Action Action
		{
			get => action;
			set
			{
				action = value;
				updateControls();
			}
		}

		private void updateControls()
		{
			nameTb.Text = action.Name;
			stepListBox.Items.Clear();
			foreach (var step in action.Steps)
				stepListBox.Items.Add(step.Name);
		}

		public ActionDialog()
		{
			InitializeComponent();
			action.Steps = new List<ActionStep>();
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void nameTb_TextChanged(object sender, EventArgs e)
		{
			action.Name = nameTb.Text;
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			var dlg = new ActionStepDialog();
			if (DialogResult.OK == dlg.ShowDialog())
			{
				action.Steps.Add(dlg.Step);
				stepListBox.Items.Add(dlg.Step.Name);
			}
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			var dlg = new ActionStepDialog();
			if (stepListBox.SelectedIndex == -1)
			{
				MessageBox.Show("No list entry selected");
				return;
			}
			dlg.Step = action.Steps[stepListBox.SelectedIndex];
			if (DialogResult.OK == dlg.ShowDialog())
			{
				action.Steps[stepListBox.SelectedIndex] = dlg.Step;
				updateControls();
			}
		}
	}
}
