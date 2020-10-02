namespace Lab4WithGUI
{
	partial class PortDialog
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
			this.portTb = new System.Windows.Forms.TextBox();
			this.okBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// portTb
			// 
			this.portTb.Location = new System.Drawing.Point(12, 12);
			this.portTb.Name = "portTb";
			this.portTb.Size = new System.Drawing.Size(163, 20);
			this.portTb.TabIndex = 0;
			this.portTb.Text = "COM6";
			// 
			// okBtn
			// 
			this.okBtn.Location = new System.Drawing.Point(100, 38);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 1;
			this.okBtn.Text = "Ok";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// PortDialog
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(187, 70);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.portTb);
			this.Name = "PortDialog";
			this.Text = "Enter port name";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox portTb;
		private System.Windows.Forms.Button okBtn;
	}
}