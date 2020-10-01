namespace Lab4WithGUI
{
	partial class ActionDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.stepListBox = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addBtn = new System.Windows.Forms.Button();
			this.editBtn = new System.Windows.Forms.Button();
			this.removeBtn = new System.Windows.Forms.Button();
			this.nameTb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(67, 147);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 4;
			this.okBtn.Text = "Ok";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(148, 147);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 4;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// stepListBox
			// 
			this.stepListBox.FormattingEnabled = true;
			this.stepListBox.Location = new System.Drawing.Point(12, 51);
			this.stepListBox.Name = "stepListBox";
			this.stepListBox.Size = new System.Drawing.Size(130, 82);
			this.stepListBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Steps";
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(148, 52);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 4;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(148, 81);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(75, 23);
			this.editBtn.TabIndex = 4;
			this.editBtn.Text = "Edit";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// removeBtn
			// 
			this.removeBtn.Location = new System.Drawing.Point(148, 110);
			this.removeBtn.Name = "removeBtn";
			this.removeBtn.Size = new System.Drawing.Size(75, 23);
			this.removeBtn.TabIndex = 4;
			this.removeBtn.Text = "Remove";
			this.removeBtn.UseVisualStyleBackColor = true;
			// 
			// nameTb
			// 
			this.nameTb.Location = new System.Drawing.Point(53, 6);
			this.nameTb.Name = "nameTb";
			this.nameTb.Size = new System.Drawing.Size(170, 20);
			this.nameTb.TabIndex = 9;
			this.nameTb.TextChanged += new System.EventHandler(this.nameTb_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Name";
			// 
			// ActionDialog
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(235, 182);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameTb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.stepListBox);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.removeBtn);
			this.Controls.Add(this.okBtn);
			this.Name = "ActionDialog";
			this.Text = "Action";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ListBox stepListBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.Button removeBtn;
		private System.Windows.Forms.TextBox nameTb;
		private System.Windows.Forms.Label label1;
	}
}