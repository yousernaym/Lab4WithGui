namespace Lab4WithGUI
{
	partial class Form1
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
			this.actionListbox = new System.Windows.Forms.ListBox();
			this.editBtn = new System.Windows.Forms.Button();
			this.removeBtn = new System.Windows.Forms.Button();
			this.addBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// actionListbox
			// 
			this.actionListbox.FormattingEnabled = true;
			this.actionListbox.Location = new System.Drawing.Point(12, 27);
			this.actionListbox.Name = "actionListbox";
			this.actionListbox.Size = new System.Drawing.Size(120, 108);
			this.actionListbox.TabIndex = 0;
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(138, 56);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(75, 23);
			this.editBtn.TabIndex = 1;
			this.editBtn.Text = "Edit";
			this.editBtn.UseVisualStyleBackColor = true;
			// 
			// removeBtn
			// 
			this.removeBtn.Location = new System.Drawing.Point(138, 85);
			this.removeBtn.Name = "removeBtn";
			this.removeBtn.Size = new System.Drawing.Size(75, 23);
			this.removeBtn.TabIndex = 2;
			this.removeBtn.Text = "Remove";
			this.removeBtn.UseVisualStyleBackColor = true;
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(138, 27);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 3;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Actions";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(138, 114);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 146);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.removeBtn);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.actionListbox);
			this.Name = "Form1";
			this.Text = "Lab4 UI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox actionListbox;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.Button removeBtn;
		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}

