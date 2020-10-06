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
			this.components = new System.ComponentModel.Container();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.rainbowRb = new System.Windows.Forms.RadioButton();
			this.singleColorRb = new System.Windows.Forms.RadioButton();
			this.statePanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.blinkRb = new System.Windows.Forms.RadioButton();
			this.constantRb = new System.Windows.Forms.RadioButton();
			this.colorBtn = new System.Windows.Forms.Button();
			this.singleColorPanel = new System.Windows.Forms.Panel();
			this.speedTrackbar = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.speedPanel = new System.Windows.Forms.Panel();
			this.commandsDgv = new System.Windows.Forms.DataGridView();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Recurring = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.commandListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.statePanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.singleColorPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).BeginInit();
			this.speedPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.commandsDgv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commandListBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(313, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Commands";
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
			this.rainbowRb.Click += new System.EventHandler(this.rainbowRb_Click);
			// 
			// singleColorRb
			// 
			this.singleColorRb.AutoSize = true;
			this.singleColorRb.Checked = true;
			this.singleColorRb.Location = new System.Drawing.Point(3, 3);
			this.singleColorRb.Name = "singleColorRb";
			this.singleColorRb.Size = new System.Drawing.Size(81, 17);
			this.singleColorRb.TabIndex = 0;
			this.singleColorRb.TabStop = true;
			this.singleColorRb.Text = "Single Color";
			this.singleColorRb.UseVisualStyleBackColor = true;
			this.singleColorRb.CheckedChanged += new System.EventHandler(this.singleColorRb_CheckedChanged);
			this.singleColorRb.Click += new System.EventHandler(this.singleColorRb_Click);
			// 
			// statePanel
			// 
			this.statePanel.BackColor = System.Drawing.SystemColors.Control;
			this.statePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.statePanel.Controls.Add(this.singleColorRb);
			this.statePanel.Controls.Add(this.rainbowRb);
			this.statePanel.Location = new System.Drawing.Point(12, 12);
			this.statePanel.Name = "statePanel";
			this.statePanel.Size = new System.Drawing.Size(89, 51);
			this.statePanel.TabIndex = 0;
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
			// panel1
			// 
			this.panel1.Controls.Add(this.blinkRb);
			this.panel1.Controls.Add(this.constantRb);
			this.panel1.Location = new System.Drawing.Point(3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(102, 46);
			this.panel1.TabIndex = 4;
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
			this.blinkRb.Click += new System.EventHandler(this.blinkRb_Click);
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
			this.constantRb.Click += new System.EventHandler(this.constantRb_Click);
			// 
			// colorBtn
			// 
			this.colorBtn.BackColor = System.Drawing.Color.Lime;
			this.colorBtn.Location = new System.Drawing.Point(114, 21);
			this.colorBtn.Name = "colorBtn";
			this.colorBtn.Size = new System.Drawing.Size(75, 23);
			this.colorBtn.TabIndex = 7;
			this.colorBtn.UseVisualStyleBackColor = false;
			this.colorBtn.BackColorChanged += new System.EventHandler(this.colorBtn_BackColorChanged);
			this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
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
			// speedTrackbar
			// 
			this.speedTrackbar.LargeChange = 64;
			this.speedTrackbar.Location = new System.Drawing.Point(8, 22);
			this.speedTrackbar.Maximum = 255;
			this.speedTrackbar.Name = "speedTrackbar";
			this.speedTrackbar.Size = new System.Drawing.Size(278, 45);
			this.speedTrackbar.TabIndex = 5;
			this.speedTrackbar.TickFrequency = 32;
			this.speedTrackbar.Value = 128;
			this.speedTrackbar.Scroll += new System.EventHandler(this.speedTrackbar_Scroll);
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
			// commandsDgv
			// 
			this.commandsDgv.AutoGenerateColumns = false;
			this.commandsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.commandsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Delay,
            this.Recurring,
            this.Active});
			this.commandsDgv.DataSource = this.commandListBindingSource;
			this.commandsDgv.Location = new System.Drawing.Point(316, 25);
			this.commandsDgv.Name = "commandsDgv";
			this.commandsDgv.Size = new System.Drawing.Size(294, 117);
			this.commandsDgv.TabIndex = 15;
			this.commandsDgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.commandsDgv_CellEndEdit);
			this.commandsDgv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.commandsDgv_CellValidating);
			this.commandsDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.commandsDgv_RowsAdded);
			// 
			// Description
			// 
			this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Description.DataPropertyName = "Description";
			this.Description.FillWeight = 380F;
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			// 
			// Delay
			// 
			this.Delay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Delay.DataPropertyName = "Delay";
			this.Delay.FillWeight = 200F;
			this.Delay.HeaderText = "Delay";
			this.Delay.Name = "Delay";
			// 
			// Recurring
			// 
			this.Recurring.FillWeight = 170F;
			this.Recurring.HeaderText = "Recurring";
			this.Recurring.Name = "Recurring";
			this.Recurring.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Recurring.Width = 60;
			// 
			// Active
			// 
			this.Active.DataPropertyName = "Active";
			this.Active.HeaderText = "Active";
			this.Active.Name = "Active";
			this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Active.Width = 40;
			// 
			// commandListBindingSource
			// 
			this.commandListBindingSource.DataSource = typeof(Lab4WithGUI.CommandList);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 148);
			this.Controls.Add(this.commandsDgv);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.speedPanel);
			this.Controls.Add(this.singleColorPanel);
			this.Controls.Add(this.statePanel);
			this.Name = "Form1";
			this.Text = "Lab4 UI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.statePanel.ResumeLayout(false);
			this.statePanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.singleColorPanel.ResumeLayout(false);
			this.singleColorPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).EndInit();
			this.speedPanel.ResumeLayout(false);
			this.speedPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.commandsDgv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commandListBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rainbowRb;
		private System.Windows.Forms.RadioButton singleColorRb;
		private System.Windows.Forms.Panel statePanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton blinkRb;
		private System.Windows.Forms.RadioButton constantRb;
		private System.Windows.Forms.Button colorBtn;
		private System.Windows.Forms.Panel singleColorPanel;
		private System.Windows.Forms.TrackBar speedTrackbar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel speedPanel;
		private System.Windows.Forms.DataGridView commandsDgv;
		private System.Windows.Forms.BindingSource commandListBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Recurring;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
	}
}

