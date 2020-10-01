namespace Lab4WithGUI
{
	partial class ActionStepDialog
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
			this.fadeCb = new System.Windows.Forms.CheckBox();
			this.colorBtn = new System.Windows.Forms.Button();
			this.timeUd = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nameTb = new System.Windows.Forms.TextBox();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.okBtn = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.timeUd)).BeginInit();
			this.SuspendLayout();
			// 
			// fadeCb
			// 
			this.fadeCb.AutoSize = true;
			this.fadeCb.Location = new System.Drawing.Point(123, 66);
			this.fadeCb.Name = "fadeCb";
			this.fadeCb.Size = new System.Drawing.Size(50, 17);
			this.fadeCb.TabIndex = 13;
			this.fadeCb.Text = "Fade";
			this.fadeCb.UseVisualStyleBackColor = true;
			this.fadeCb.CheckedChanged += new System.EventHandler(this.fadeCb_CheckedChanged);
			// 
			// colorBtn
			// 
			this.colorBtn.Location = new System.Drawing.Point(53, 62);
			this.colorBtn.Name = "colorBtn";
			this.colorBtn.Size = new System.Drawing.Size(64, 23);
			this.colorBtn.TabIndex = 12;
			this.colorBtn.UseVisualStyleBackColor = true;
			this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
			// 
			// timeUd
			// 
			this.timeUd.Location = new System.Drawing.Point(53, 36);
			this.timeUd.Name = "timeUd";
			this.timeUd.Size = new System.Drawing.Size(120, 20);
			this.timeUd.TabIndex = 11;
			this.timeUd.ValueChanged += new System.EventHandler(this.timeUd_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Color";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Time";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Name";
			// 
			// nameTb
			// 
			this.nameTb.Location = new System.Drawing.Point(53, 10);
			this.nameTb.Name = "nameTb";
			this.nameTb.Size = new System.Drawing.Size(120, 20);
			this.nameTb.TabIndex = 7;
			this.nameTb.TextChanged += new System.EventHandler(this.nameTb_TextChanged);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(100, 100);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 14;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(19, 100);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 15;
			this.okBtn.Text = "Ok";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// ActionStepDialog
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(187, 135);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.fadeCb);
			this.Controls.Add(this.colorBtn);
			this.Controls.Add(this.timeUd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameTb);
			this.Name = "ActionStepDialog";
			((System.ComponentModel.ISupportInitialize)(this.timeUd)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox fadeCb;
		private System.Windows.Forms.Button colorBtn;
		private System.Windows.Forms.NumericUpDown timeUd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTb;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}