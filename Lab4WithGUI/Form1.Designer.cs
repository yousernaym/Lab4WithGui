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
			this.state0Rb = new System.Windows.Forms.RadioButton();
			this.rainbowRb = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statePanel = new System.Windows.Forms.Panel();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.colorBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.singleColorPanel = new System.Windows.Forms.Panel();
			this.speedPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.statePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.singleColorPanel.SuspendLayout();
			this.speedPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// state0Rb
			// 
			this.state0Rb.AutoSize = true;
			this.state0Rb.Checked = true;
			this.state0Rb.Location = new System.Drawing.Point(3, 3);
			this.state0Rb.Name = "state0Rb";
			this.state0Rb.Size = new System.Drawing.Size(81, 17);
			this.state0Rb.TabIndex = 0;
			this.state0Rb.TabStop = true;
			this.state0Rb.Text = "Single Color";
			this.state0Rb.UseVisualStyleBackColor = true;
			// 
			// rainbowRb
			// 
			this.rainbowRb.AutoSize = true;
			this.rainbowRb.Location = new System.Drawing.Point(3, 26);
			this.rainbowRb.Name = "rainbowRb";
			this.rainbowRb.Size = new System.Drawing.Size(67, 17);
			this.rainbowRb.TabIndex = 1;
			this.rainbowRb.TabStop = true;
			this.rainbowRb.Text = "Rainbow";
			this.rainbowRb.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(0, 26);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(48, 17);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Blink";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Checked = true;
			this.radioButton4.Location = new System.Drawing.Point(0, 3);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(89, 17);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Constant light";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton3);
			this.panel1.Controls.Add(this.radioButton4);
			this.panel1.Location = new System.Drawing.Point(3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(102, 46);
			this.panel1.TabIndex = 4;
			// 
			// statePanel
			// 
			this.statePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.statePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.statePanel.Controls.Add(this.state0Rb);
			this.statePanel.Controls.Add(this.rainbowRb);
			this.statePanel.Location = new System.Drawing.Point(12, 12);
			this.statePanel.Name = "statePanel";
			this.statePanel.Size = new System.Drawing.Size(89, 51);
			this.statePanel.TabIndex = 0;
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 25;
			this.trackBar1.Location = new System.Drawing.Point(8, 22);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(278, 45);
			this.trackBar1.TabIndex = 5;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.Value = 50;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Fade/Blink Speed";
			// 
			// colorBtn
			// 
			this.colorBtn.BackColor = System.Drawing.Color.Lime;
			this.colorBtn.Location = new System.Drawing.Point(114, 21);
			this.colorBtn.Name = "colorBtn";
			this.colorBtn.Size = new System.Drawing.Size(75, 23);
			this.colorBtn.TabIndex = 7;
			this.colorBtn.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(111, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Color";
			// 
			// singleColorPanel
			// 
			this.singleColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.singleColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.singleColorPanel.Controls.Add(this.colorBtn);
			this.singleColorPanel.Controls.Add(this.panel1);
			this.singleColorPanel.Controls.Add(this.label2);
			this.singleColorPanel.Location = new System.Drawing.Point(107, 12);
			this.singleColorPanel.Name = "singleColorPanel";
			this.singleColorPanel.Size = new System.Drawing.Size(200, 51);
			this.singleColorPanel.TabIndex = 8;
			// 
			// speedPanel
			// 
			this.speedPanel.BackColor = System.Drawing.SystemColors.Control;
			this.speedPanel.Controls.Add(this.label1);
			this.speedPanel.Controls.Add(this.trackBar1);
			this.speedPanel.Location = new System.Drawing.Point(12, 69);
			this.speedPanel.Name = "speedPanel";
			this.speedPanel.Size = new System.Drawing.Size(294, 73);
			this.speedPanel.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 139);
			this.Controls.Add(this.speedPanel);
			this.Controls.Add(this.singleColorPanel);
			this.Controls.Add(this.statePanel);
			this.Name = "Form1";
			this.Text = "Lab4 UI";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.statePanel.ResumeLayout(false);
			this.statePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.singleColorPanel.ResumeLayout(false);
			this.singleColorPanel.PerformLayout();
			this.speedPanel.ResumeLayout(false);
			this.speedPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton state0Rb;
		private System.Windows.Forms.RadioButton rainbowRb;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel speedPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel statePanel;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button colorBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel singleColorPanel;
	}
}

