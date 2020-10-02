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
			this.blinkRb = new System.Windows.Forms.RadioButton();
			this.constantRb = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.statePanel = new System.Windows.Forms.Panel();
			this.speedTrackbar = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.colorBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.singleColorPanel = new System.Windows.Forms.Panel();
			this.speedPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.statePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).BeginInit();
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
			this.state0Rb.CheckedChanged += new System.EventHandler(this.singleColorRb_CheckedChanged);
			// 
			// rainbowRb
			// 
			this.rainbowRb.AutoSize = true;
			this.rainbowRb.Location = new System.Drawing.Point(3, 26);
			this.rainbowRb.Name = "rainbowRb";
			this.rainbowRb.Size = new System.Drawing.Size(67, 17);
			this.rainbowRb.TabIndex = 1;
			this.rainbowRb.Text = "Rainbow";
			this.rainbowRb.UseVisualStyleBackColor = true;
			this.rainbowRb.CheckedChanged += new System.EventHandler(this.rainbowRb_CheckedChanged);
			// 
			// blinkRb
			// 
			this.blinkRb.AutoSize = true;
			this.blinkRb.Location = new System.Drawing.Point(0, 26);
			this.blinkRb.Name = "blinkRb";
			this.blinkRb.Size = new System.Drawing.Size(48, 17);
			this.blinkRb.TabIndex = 2;
			this.blinkRb.Text = "Blink";
			this.blinkRb.UseVisualStyleBackColor = true;
			this.blinkRb.CheckedChanged += new System.EventHandler(this.blinkRb_CheckedChanged);
			// 
			// constantRb
			// 
			this.constantRb.AutoSize = true;
			this.constantRb.Checked = true;
			this.constantRb.Location = new System.Drawing.Point(0, 3);
			this.constantRb.Name = "constantRb";
			this.constantRb.Size = new System.Drawing.Size(89, 17);
			this.constantRb.TabIndex = 3;
			this.constantRb.TabStop = true;
			this.constantRb.Text = "Constant light";
			this.constantRb.UseVisualStyleBackColor = true;
			this.constantRb.CheckedChanged += new System.EventHandler(this.constantRb_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.blinkRb);
			this.panel1.Controls.Add(this.constantRb);
			this.panel1.Location = new System.Drawing.Point(3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(102, 46);
			this.panel1.TabIndex = 4;
			// 
			// statePanel
			// 
			this.statePanel.BackColor = System.Drawing.SystemColors.Control;
			this.statePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.statePanel.Controls.Add(this.state0Rb);
			this.statePanel.Controls.Add(this.rainbowRb);
			this.statePanel.Location = new System.Drawing.Point(12, 12);
			this.statePanel.Name = "statePanel";
			this.statePanel.Size = new System.Drawing.Size(89, 51);
			this.statePanel.TabIndex = 0;
			// 
			// speedTrackbar
			// 
			this.speedTrackbar.LargeChange = 25;
			this.speedTrackbar.Location = new System.Drawing.Point(8, 22);
			this.speedTrackbar.Maximum = 100;
			this.speedTrackbar.Name = "speedTrackbar";
			this.speedTrackbar.Size = new System.Drawing.Size(278, 45);
			this.speedTrackbar.TabIndex = 5;
			this.speedTrackbar.TickFrequency = 10;
			this.speedTrackbar.Value = 50;
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
			this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
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
			this.singleColorPanel.BackColor = System.Drawing.SystemColors.Control;
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
			this.speedPanel.Controls.Add(this.speedTrackbar);
			this.speedPanel.Enabled = false;
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
			((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).EndInit();
			this.singleColorPanel.ResumeLayout(false);
			this.singleColorPanel.PerformLayout();
			this.speedPanel.ResumeLayout(false);
			this.speedPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton state0Rb;
		private System.Windows.Forms.RadioButton rainbowRb;
		private System.Windows.Forms.RadioButton blinkRb;
		private System.Windows.Forms.RadioButton constantRb;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel speedPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel statePanel;
		private System.Windows.Forms.TrackBar speedTrackbar;
		private System.Windows.Forms.Button colorBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel singleColorPanel;
	}
}

