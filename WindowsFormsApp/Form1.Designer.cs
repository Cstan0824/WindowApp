using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;
using System;
using System.ComponentModel;
namespace WindowsFormsApp
{
	partial class Forms
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.VMenuStrip = new System.Windows.Forms.MenuStrip();
			this.IndexItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DataStatusItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LineGraphItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.PageLabel = new System.Windows.Forms.Label();
			this.HMenuStrip = new System.Windows.Forms.MenuStrip();
			this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RunItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PauseItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DataPanel = new System.Windows.Forms.Panel();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.ChartPanel = new System.Windows.Forms.Panel();
			this.ZoomPanel = new System.Windows.Forms.Panel();
			this.MinusSign = new System.Windows.Forms.Label();
			this.AddSign = new System.Windows.Forms.Label();
			this.ResetButton = new System.Windows.Forms.Button();
			this.hScrollBar = new System.Windows.Forms.HScrollBar();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.TitlePanel = new System.Windows.Forms.Panel();
			this.DataStatusTextBox = new System.Windows.Forms.TextBox();
			this.TimeTextBox = new System.Windows.Forms.TextBox();
			this.DataTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
			this.VMenuStrip.SuspendLayout();
			this.HMenuStrip.SuspendLayout();
			this.DataPanel.SuspendLayout();
			this.ChartPanel.SuspendLayout();
			this.ZoomPanel.SuspendLayout();
			this.TitlePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Chart
			// 
			this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Chart.BackColor = System.Drawing.Color.Gainsboro;
			chartArea1.AxisX.IsLabelAutoFit = false;
			chartArea1.AxisX.LabelAutoFitMaxFontSize = 12;
			chartArea1.AxisX.LabelStyle.Angle = 45;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
			chartArea1.AxisY.MajorTickMark.Enabled = false;
			chartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			chartArea1.CursorY.IsUserSelectionEnabled = true;
			chartArea1.Name = "ChartArea1";
			this.Chart.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Gainsboro;
			legend1.Name = "Legend";
			legend1.Title = "Random ";
			this.Chart.Legends.Add(legend1);
			this.Chart.Location = new System.Drawing.Point(0, 0);
			this.Chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Chart.Name = "Chart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend";
			series1.Name = "RndData";
			this.Chart.Series.Add(series1);
			this.Chart.Size = new System.Drawing.Size(875, 972);
			this.Chart.TabIndex = 0;
			this.Chart.Text = "chart1";
			// 
			// VMenuStrip
			// 
			this.VMenuStrip.AllowMerge = false;
			this.VMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.VMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
			this.VMenuStrip.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.VMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IndexItem,
            this.DataStatusItem,
            this.LineGraphItem});
			this.VMenuStrip.Location = new System.Drawing.Point(0, 76);
			this.VMenuStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.VMenuStrip.Name = "VMenuStrip";
			this.VMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.VMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.VMenuStrip.Size = new System.Drawing.Size(228, 1004);
			this.VMenuStrip.TabIndex = 1;
			this.VMenuStrip.Text = "menuStrip";
			// 
			// IndexItem
			// 
			this.IndexItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.IndexItem.Enabled = false;
			this.IndexItem.Name = "IndexItem";
			this.IndexItem.Padding = new System.Windows.Forms.Padding(5, 15, 5, 15);
			this.IndexItem.Size = new System.Drawing.Size(217, 68);
			this.IndexItem.Text = "INDEX";
			this.IndexItem.Click += new System.EventHandler(this.IndexItem_Click);
			// 
			// DataStatusItem
			// 
			this.DataStatusItem.Name = "DataStatusItem";
			this.DataStatusItem.Padding = new System.Windows.Forms.Padding(5, 15, 5, 15);
			this.DataStatusItem.Size = new System.Drawing.Size(217, 68);
			this.DataStatusItem.Text = "DATA STATUS";
			this.DataStatusItem.Click += new System.EventHandler(this.DataStatusItem_Click);
			// 
			// LineGraphItem
			// 
			this.LineGraphItem.Name = "LineGraphItem";
			this.LineGraphItem.Padding = new System.Windows.Forms.Padding(5, 15, 5, 15);
			this.LineGraphItem.Size = new System.Drawing.Size(217, 68);
			this.LineGraphItem.Text = "LINE GRAPH";
			this.LineGraphItem.Click += new System.EventHandler(this.LineGraphItem_Click);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// PageLabel
			// 
			this.PageLabel.AutoSize = true;
			this.PageLabel.BackColor = System.Drawing.Color.SkyBlue;
			this.PageLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PageLabel.ForeColor = System.Drawing.Color.Black;
			this.PageLabel.Location = new System.Drawing.Point(12, 21);
			this.PageLabel.Name = "PageLabel";
			this.PageLabel.Size = new System.Drawing.Size(108, 34);
			this.PageLabel.TabIndex = 4;
			this.PageLabel.Text = "INDEX";
			// 
			// HMenuStrip
			// 
			this.HMenuStrip.BackColor = System.Drawing.Color.SkyBlue;
			this.HMenuStrip.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.HMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitItem,
            this.RunItem,
            this.PauseItem});
			this.HMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.HMenuStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.HMenuStrip.Name = "HMenuStrip";
			this.HMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.HMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.HMenuStrip.Size = new System.Drawing.Size(1920, 76);
			this.HMenuStrip.TabIndex = 5;
			this.HMenuStrip.Text = "menuStrip1";
			// 
			// ExitItem
			// 
			this.ExitItem.ForeColor = System.Drawing.Color.Gainsboro;
			this.ExitItem.Name = "ExitItem";
			this.ExitItem.Size = new System.Drawing.Size(179, 72);
			this.ExitItem.Text = "EXIT";
			this.ExitItem.Click += new System.EventHandler(this.ExitItem_Click);
			// 
			// RunItem
			// 
			this.RunItem.CheckOnClick = true;
			this.RunItem.ForeColor = System.Drawing.Color.Gainsboro;
			this.RunItem.Name = "RunItem";
			this.RunItem.Size = new System.Drawing.Size(169, 72);
			this.RunItem.Text = "RUN";
			this.RunItem.Click += new System.EventHandler(this.RunItem_Click);
			// 
			// PauseItem
			// 
			this.PauseItem.Enabled = false;
			this.PauseItem.ForeColor = System.Drawing.Color.Gainsboro;
			this.PauseItem.Name = "PauseItem";
			this.PauseItem.Size = new System.Drawing.Size(225, 72);
			this.PauseItem.Text = "PAUSE";
			this.PauseItem.Click += new System.EventHandler(this.PauseItem_Click);
			// 
			// DataPanel
			// 
			this.DataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.DataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))));
			this.DataPanel.Controls.Add(this.listBox2);
			this.DataPanel.Controls.Add(this.listBox1);
			this.DataPanel.Location = new System.Drawing.Point(267, 166);
			this.DataPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DataPanel.Name = "DataPanel";
			this.DataPanel.Size = new System.Drawing.Size(694, 903);
			this.DataPanel.TabIndex = 6;
			// 
			// listBox2
			// 
			this.listBox2.BackColor = System.Drawing.Color.Gainsboro;
			this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox2.Font = new System.Drawing.Font("Times New Roman", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 52;
			this.listBox2.Location = new System.Drawing.Point(33, 58);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 52);
			this.listBox2.TabIndex = 11;
			this.listBox2.Visible = false;
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 34;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(694, 884);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// ChartPanel
			// 
			this.ChartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))));
			this.ChartPanel.Controls.Add(this.Chart);
			this.ChartPanel.Location = new System.Drawing.Point(1022, 97);
			this.ChartPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ChartPanel.Name = "ChartPanel";
			this.ChartPanel.Size = new System.Drawing.Size(875, 972);
			this.ChartPanel.TabIndex = 7;
			// 
			// ZoomPanel
			// 
			this.ZoomPanel.BackColor = System.Drawing.Color.SkyBlue;
			this.ZoomPanel.Controls.Add(this.MinusSign);
			this.ZoomPanel.Controls.Add(this.AddSign);
			this.ZoomPanel.Controls.Add(this.ResetButton);
			this.ZoomPanel.Controls.Add(this.hScrollBar);
			this.ZoomPanel.Location = new System.Drawing.Point(641, 2);
			this.ZoomPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ZoomPanel.Name = "ZoomPanel";
			this.ZoomPanel.Size = new System.Drawing.Size(696, 55);
			this.ZoomPanel.TabIndex = 8;
			// 
			// MinusSign
			// 
			this.MinusSign.AutoSize = true;
			this.MinusSign.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinusSign.ForeColor = System.Drawing.Color.DimGray;
			this.MinusSign.Location = new System.Drawing.Point(61, 5);
			this.MinusSign.Name = "MinusSign";
			this.MinusSign.Size = new System.Drawing.Size(29, 48);
			this.MinusSign.TabIndex = 10;
			this.MinusSign.Text = "-";
			// 
			// AddSign
			// 
			this.AddSign.AutoSize = true;
			this.AddSign.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddSign.ForeColor = System.Drawing.Color.DimGray;
			this.AddSign.Location = new System.Drawing.Point(515, 5);
			this.AddSign.Name = "AddSign";
			this.AddSign.Size = new System.Drawing.Size(33, 48);
			this.AddSign.TabIndex = 2;
			this.AddSign.Text = "+";
			// 
			// ResetButton
			// 
			this.ResetButton.BackColor = System.Drawing.Color.SkyBlue;
			this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.ResetButton.FlatAppearance.BorderSize = 0;
			this.ResetButton.ForeColor = System.Drawing.Color.Black;
			this.ResetButton.Location = new System.Drawing.Point(575, 14);
			this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(95, 37);
			this.ResetButton.TabIndex = 1;
			this.ResetButton.Text = "RESET";
			this.ResetButton.UseVisualStyleBackColor = false;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// hScrollBar
			// 
			this.hScrollBar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.hScrollBar.LargeChange = 1;
			this.hScrollBar.Location = new System.Drawing.Point(93, 10);
			this.hScrollBar.Maximum = 9;
			this.hScrollBar.Minimum = 1;
			this.hScrollBar.Name = "hScrollBar";
			this.hScrollBar.Size = new System.Drawing.Size(419, 37);
			this.hScrollBar.TabIndex = 0;
			this.hScrollBar.Value = 5;
			this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.BackColor = System.Drawing.Color.SkyBlue;
			this.StatusLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatusLabel.ForeColor = System.Drawing.Color.Black;
			this.StatusLabel.Location = new System.Drawing.Point(237, 18);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(319, 37);
			this.StatusLabel.TabIndex = 9;
			this.StatusLabel.Text = "PROGRAM: PAUSED";
			// 
			// TitlePanel
			// 
			this.TitlePanel.BackColor = System.Drawing.Color.Gainsboro;
			this.TitlePanel.Controls.Add(this.DataStatusTextBox);
			this.TitlePanel.Controls.Add(this.TimeTextBox);
			this.TitlePanel.Controls.Add(this.DataTextBox);
			this.TitlePanel.Location = new System.Drawing.Point(267, 97);
			this.TitlePanel.Name = "TitlePanel";
			this.TitlePanel.Size = new System.Drawing.Size(694, 69);
			this.TitlePanel.TabIndex = 10;
			// 
			// DataStatusTextBox
			// 
			this.DataStatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.DataStatusTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.DataStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataStatusTextBox.Enabled = false;
			this.DataStatusTextBox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataStatusTextBox.Location = new System.Drawing.Point(3, 13);
			this.DataStatusTextBox.Name = "DataStatusTextBox";
			this.DataStatusTextBox.ReadOnly = true;
			this.DataStatusTextBox.Size = new System.Drawing.Size(296, 38);
			this.DataStatusTextBox.TabIndex = 3;
			this.DataStatusTextBox.Text = "DATA STATUS";
			this.DataStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TimeTextBox
			// 
			this.TimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TimeTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.TimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TimeTextBox.Enabled = false;
			this.TimeTextBox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeTextBox.HideSelection = false;
			this.TimeTextBox.Location = new System.Drawing.Point(452, 13);
			this.TimeTextBox.Name = "TimeTextBox";
			this.TimeTextBox.ReadOnly = true;
			this.TimeTextBox.Size = new System.Drawing.Size(105, 38);
			this.TimeTextBox.TabIndex = 2;
			this.TimeTextBox.TabStop = false;
			this.TimeTextBox.Text = "TIME           ";
			this.TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// DataTextBox
			// 
			this.DataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.DataTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.DataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataTextBox.Enabled = false;
			this.DataTextBox.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataTextBox.HideSelection = false;
			this.DataTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.DataTextBox.Location = new System.Drawing.Point(573, 13);
			this.DataTextBox.Name = "DataTextBox";
			this.DataTextBox.ReadOnly = true;
			this.DataTextBox.Size = new System.Drawing.Size(99, 38);
			this.DataTextBox.TabIndex = 1;
			this.DataTextBox.Text = "DATA";
			this.DataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Forms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))));
			this.ClientSize = new System.Drawing.Size(1920, 1080);
			this.Controls.Add(this.TitlePanel);
			this.Controls.Add(this.StatusLabel);
			this.Controls.Add(this.ZoomPanel);
			this.Controls.Add(this.DataPanel);
			this.Controls.Add(this.PageLabel);
			this.Controls.Add(this.VMenuStrip);
			this.Controls.Add(this.HMenuStrip);
			this.Controls.Add(this.ChartPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.VMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(1536, 960);
			this.Name = "Forms";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
			this.VMenuStrip.ResumeLayout(false);
			this.VMenuStrip.PerformLayout();
			this.HMenuStrip.ResumeLayout(false);
			this.HMenuStrip.PerformLayout();
			this.DataPanel.ResumeLayout(false);
			this.ChartPanel.ResumeLayout(false);
			this.ZoomPanel.ResumeLayout(false);
			this.ZoomPanel.PerformLayout();
			this.TitlePanel.ResumeLayout(false);
			this.TitlePanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Chart Chart;
		private MenuStrip VMenuStrip;
		private ToolStripMenuItem IndexItem;
		private ToolStripMenuItem DataStatusItem;
		private ToolStripMenuItem LineGraphItem;
		private Timer timer;
		private Label PageLabel;
		private MenuStrip HMenuStrip;
		private ToolStripMenuItem ExitItem;
		private ToolStripMenuItem RunItem;
		private ToolStripMenuItem PauseItem;
		private	Panel DataPanel;
		private Panel ChartPanel;
		private ListBox listBox1;
		private	Panel ZoomPanel;
		private	HScrollBar hScrollBar;
		private Label StatusLabel;
		private Button ResetButton;
		private Label MinusSign;
		private Label AddSign;
		private Panel TitlePanel;
		private TextBox DataStatusTextBox;
		private	TextBox TimeTextBox;
		private TextBox DataTextBox;
		private ListBox listBox2;
	}
}

