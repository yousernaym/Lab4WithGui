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

		private void actionListbox_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			editBtn.Enabled = removeBtn.Enabled = runBtn.Enabled = actionListbox.SelectedIndex >= 0;
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			var dlg = new ActionDialog();
			if (DialogResult.OK == dlg.ShowDialog())
			{
				actions.Add(dlg.Action); ;
				actionListbox.Items.Add(dlg.Action.Name);
			}
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			var dlg = new ActionDialog();
			dlg.Action = actions[actionListbox.SelectedIndex];
			if (DialogResult.OK == dlg.ShowDialog())
			{
				actions[actionListbox.SelectedIndex] = dlg.Action;
				updateControls();
			}
		}

		private void removeBtn_Click(object sender, EventArgs e)
		{
			actions.RemoveAt(actionListbox.SelectedIndex);
			updateControls();
		}

		private void updateControls()
		{
			actionListbox.Items.Clear();
			foreach (var action in actions)
				actionListbox.Items.Add(action.Name);
		}
	}
}
