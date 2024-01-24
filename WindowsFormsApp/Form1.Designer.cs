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
			this.DataDisplayPanel = new System.Windows.Forms.Panel();
			this.DataStatusPanel = new System.Windows.Forms.Panel();
			this.TimePanel = new System.Windows.Forms.Panel();
			this.DataPanel = new System.Windows.Forms.Panel();
			this.ChartPanel = new System.Windows.Forms.Panel();
			this.ZoomPanel = new System.Windows.Forms.Panel();
			this.ResetButton = new System.Windows.Forms.Button();
			this.hScrollBar = new System.Windows.Forms.HScrollBar();
			this.TitleDisplayPanel = new System.Windows.Forms.Panel();
			this.DataStatusTitlePanel = new System.Windows.Forms.Panel();
			this.DataStatusTextBox = new System.Windows.Forms.TextBox();
			this.DataTimePanel = new System.Windows.Forms.Panel();
			this.TimeTextBox = new System.Windows.Forms.TextBox();
			this.DataTitlePanel = new System.Windows.Forms.Panel();
			this.DataTextBox = new System.Windows.Forms.TextBox();
			this.RunItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PauseItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HMenuStrip = new System.Windows.Forms.MenuStrip();
			this.Title = new System.Windows.Forms.Label();
			this.TrackButton = new System.Windows.Forms.Button();
			this.NavBarPanel = new System.Windows.Forms.Panel();
			this.TrackButtonPanel = new System.Windows.Forms.Panel();
			this.CurrDataPanel = new System.Windows.Forms.Panel();
			this.DataLabel = new System.Windows.Forms.Label();
			this.CurrTimePanel = new System.Windows.Forms.Panel();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.DataStatusListBox = new WindowsFormsApp.UserDefinedListBox();
			this.TimeListBox = new WindowsFormsApp.UserDefinedListBox();
			this.DataListBox = new WindowsFormsApp.UserDefinedListBox();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
			this.VMenuStrip.SuspendLayout();
			this.DataDisplayPanel.SuspendLayout();
			this.DataStatusPanel.SuspendLayout();
			this.TimePanel.SuspendLayout();
			this.DataPanel.SuspendLayout();
			this.ChartPanel.SuspendLayout();
			this.ZoomPanel.SuspendLayout();
			this.TitleDisplayPanel.SuspendLayout();
			this.DataStatusTitlePanel.SuspendLayout();
			this.DataTimePanel.SuspendLayout();
			this.DataTitlePanel.SuspendLayout();
			this.HMenuStrip.SuspendLayout();
			this.NavBarPanel.SuspendLayout();
			this.TrackButtonPanel.SuspendLayout();
			this.CurrDataPanel.SuspendLayout();
			this.CurrTimePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Chart
			// 
			this.Chart.BackColor = System.Drawing.Color.Gainsboro;
			this.Chart.BorderlineColor = System.Drawing.Color.Black;
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
			this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.BackColor = System.Drawing.Color.Gainsboro;
			legend1.Name = "Legend";
			legend1.Title = "Random ";
			this.Chart.Legends.Add(legend1);
			this.Chart.Location = new System.Drawing.Point(25, 25);
			this.Chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Chart.Name = "Chart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series1.IsValueShownAsLabel = true;
			series1.LabelBorderColor = System.Drawing.Color.Transparent;
			series1.LabelBorderWidth = 2;
			series1.Legend = "Legend";
			series1.MarkerBorderColor = System.Drawing.Color.Black;
			series1.MarkerBorderWidth = 2;
			series1.MarkerColor = System.Drawing.Color.White;
			series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series1.Name = "RndData";
			this.Chart.Series.Add(series1);
			this.Chart.Size = new System.Drawing.Size(639, 780);
			this.Chart.TabIndex = 0;
			this.Chart.Text = "StatusListBox";
			// 
			// VMenuStrip
			// 
			this.VMenuStrip.AllowMerge = false;
			this.VMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))));
			this.VMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
			this.VMenuStrip.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VMenuStrip.GripMargin = new System.Windows.Forms.Padding(0);
			this.VMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.VMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IndexItem,
            this.DataStatusItem,
            this.LineGraphItem});
			this.VMenuStrip.Location = new System.Drawing.Point(0, 45);
			this.VMenuStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.VMenuStrip.Name = "VMenuStrip";
			this.VMenuStrip.Padding = new System.Windows.Forms.Padding(0);
			this.VMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.VMenuStrip.Size = new System.Drawing.Size(197, 908);
			this.VMenuStrip.TabIndex = 1;
			this.VMenuStrip.Text = "menuStrip";
			// 
			// IndexItem
			// 
			this.IndexItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(223)))), ((int)(((byte)(235)))));
			this.IndexItem.Enabled = false;
			this.IndexItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IndexItem.ForeColor = System.Drawing.Color.White;
			this.IndexItem.Margin = new System.Windows.Forms.Padding(0, 0, -1, 0);
			this.IndexItem.MergeIndex = 0;
			this.IndexItem.Name = "IndexItem";
			this.IndexItem.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
			this.IndexItem.Size = new System.Drawing.Size(197, 72);
			this.IndexItem.Text = "INDEX";
			this.IndexItem.Click += new System.EventHandler(this.IndexItem_Click);
			// 
			// DataStatusItem
			// 
			this.DataStatusItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))));
			this.DataStatusItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataStatusItem.ForeColor = System.Drawing.Color.White;
			this.DataStatusItem.Margin = new System.Windows.Forms.Padding(0, 0, -1, 0);
			this.DataStatusItem.Name = "DataStatusItem";
			this.DataStatusItem.Padding = new System.Windows.Forms.Padding(5, 15, 5, 15);
			this.DataStatusItem.Size = new System.Drawing.Size(197, 72);
			this.DataStatusItem.Text = "DATA STATUS";
			this.DataStatusItem.Click += new System.EventHandler(this.DataStatusItem_Click);
			// 
			// LineGraphItem
			// 
			this.LineGraphItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LineGraphItem.ForeColor = System.Drawing.Color.White;
			this.LineGraphItem.Margin = new System.Windows.Forms.Padding(0, 0, -1, 0);
			this.LineGraphItem.Name = "LineGraphItem";
			this.LineGraphItem.Padding = new System.Windows.Forms.Padding(5, 15, 5, 15);
			this.LineGraphItem.Size = new System.Drawing.Size(197, 72);
			this.LineGraphItem.Text = "LINE GRAPH";
			this.LineGraphItem.Click += new System.EventHandler(this.LineGraphItem_Click);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// DataDisplayPanel
			// 
			this.DataDisplayPanel.BackColor = System.Drawing.Color.Transparent;
			this.DataDisplayPanel.Controls.Add(this.DataStatusPanel);
			this.DataDisplayPanel.Controls.Add(this.TimePanel);
			this.DataDisplayPanel.Controls.Add(this.DataPanel);
			this.DataDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataDisplayPanel.Location = new System.Drawing.Point(197, 114);
			this.DataDisplayPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DataDisplayPanel.Name = "DataDisplayPanel";
			this.DataDisplayPanel.Size = new System.Drawing.Size(696, 761);
			this.DataDisplayPanel.TabIndex = 6;
			// 
			// DataStatusPanel
			// 
			this.DataStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DataStatusPanel.Controls.Add(this.DataStatusListBox);
			this.DataStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataStatusPanel.Location = new System.Drawing.Point(0, 0);
			this.DataStatusPanel.Margin = new System.Windows.Forms.Padding(4);
			this.DataStatusPanel.Name = "DataStatusPanel";
			this.DataStatusPanel.Size = new System.Drawing.Size(408, 761);
			this.DataStatusPanel.TabIndex = 0;
			// 
			// TimePanel
			// 
			this.TimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TimePanel.Controls.Add(this.TimeListBox);
			this.TimePanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.TimePanel.Location = new System.Drawing.Point(408, 0);
			this.TimePanel.Margin = new System.Windows.Forms.Padding(4);
			this.TimePanel.Name = "TimePanel";
			this.TimePanel.Size = new System.Drawing.Size(164, 761);
			this.TimePanel.TabIndex = 0;
			// 
			// DataPanel
			// 
			this.DataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DataPanel.Controls.Add(this.DataListBox);
			this.DataPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.DataPanel.Location = new System.Drawing.Point(572, 0);
			this.DataPanel.Margin = new System.Windows.Forms.Padding(4);
			this.DataPanel.Name = "DataPanel";
			this.DataPanel.Size = new System.Drawing.Size(124, 761);
			this.DataPanel.TabIndex = 1;
			// 
			// ChartPanel
			// 
			this.ChartPanel.BackColor = System.Drawing.Color.Transparent;
			this.ChartPanel.Controls.Add(this.Chart);
			this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.ChartPanel.Location = new System.Drawing.Point(893, 45);
			this.ChartPanel.Margin = new System.Windows.Forms.Padding(20);
			this.ChartPanel.Name = "ChartPanel";
			this.ChartPanel.Padding = new System.Windows.Forms.Padding(25);
			this.ChartPanel.Size = new System.Drawing.Size(689, 830);
			this.ChartPanel.TabIndex = 7;
			// 
			// ZoomPanel
			// 
			this.ZoomPanel.BackColor = System.Drawing.Color.Transparent;
			this.ZoomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ZoomPanel.Controls.Add(this.ResetButton);
			this.ZoomPanel.Controls.Add(this.hScrollBar);
			this.ZoomPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.ZoomPanel.Location = new System.Drawing.Point(789, 0);
			this.ZoomPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ZoomPanel.Name = "ZoomPanel";
			this.ZoomPanel.Size = new System.Drawing.Size(596, 78);
			this.ZoomPanel.TabIndex = 8;
			// 
			// ResetButton
			// 
			this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(107)))), ((int)(((byte)(138)))));
			this.ResetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.ResetButton.FlatAppearance.BorderSize = 0;
			this.ResetButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ResetButton.Location = new System.Drawing.Point(489, 20);
			this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(95, 37);
			this.ResetButton.TabIndex = 1;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = false;
			this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// hScrollBar
			// 
			this.hScrollBar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.hScrollBar.LargeChange = 1;
			this.hScrollBar.Location = new System.Drawing.Point(44, 19);
			this.hScrollBar.Maximum = 9;
			this.hScrollBar.Minimum = 1;
			this.hScrollBar.Name = "hScrollBar";
			this.hScrollBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.hScrollBar.Size = new System.Drawing.Size(419, 37);
			this.hScrollBar.TabIndex = 0;
			this.hScrollBar.Value = 5;
			this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
			// 
			// TitleDisplayPanel
			// 
			this.TitleDisplayPanel.BackColor = System.Drawing.Color.Gainsboro;
			this.TitleDisplayPanel.Controls.Add(this.DataStatusTitlePanel);
			this.TitleDisplayPanel.Controls.Add(this.DataTimePanel);
			this.TitleDisplayPanel.Controls.Add(this.DataTitlePanel);
			this.TitleDisplayPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleDisplayPanel.Location = new System.Drawing.Point(197, 45);
			this.TitleDisplayPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TitleDisplayPanel.Name = "TitleDisplayPanel";
			this.TitleDisplayPanel.Size = new System.Drawing.Size(696, 69);
			this.TitleDisplayPanel.TabIndex = 10;
			// 
			// DataStatusTitlePanel
			// 
			this.DataStatusTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DataStatusTitlePanel.Controls.Add(this.DataStatusTextBox);
			this.DataStatusTitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataStatusTitlePanel.Location = new System.Drawing.Point(0, 0);
			this.DataStatusTitlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DataStatusTitlePanel.Name = "DataStatusTitlePanel";
			this.DataStatusTitlePanel.Size = new System.Drawing.Size(408, 69);
			this.DataStatusTitlePanel.TabIndex = 6;
			// 
			// DataStatusTextBox
			// 
			this.DataStatusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DataStatusTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.DataStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataStatusTextBox.Enabled = false;
			this.DataStatusTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataStatusTextBox.Location = new System.Drawing.Point(120, 24);
			this.DataStatusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DataStatusTextBox.Name = "DataStatusTextBox";
			this.DataStatusTextBox.ReadOnly = true;
			this.DataStatusTextBox.Size = new System.Drawing.Size(152, 31);
			this.DataStatusTextBox.TabIndex = 3;
			this.DataStatusTextBox.Text = "DATA STATUS";
			this.DataStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DataTimePanel
			// 
			this.DataTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DataTimePanel.Controls.Add(this.TimeTextBox);
			this.DataTimePanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.DataTimePanel.Location = new System.Drawing.Point(408, 0);
			this.DataTimePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DataTimePanel.Name = "DataTimePanel";
			this.DataTimePanel.Size = new System.Drawing.Size(164, 69);
			this.DataTimePanel.TabIndex = 5;
			// 
			// TimeTextBox
			// 
			this.TimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TimeTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.TimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TimeTextBox.Enabled = false;
			this.TimeTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeTextBox.HideSelection = false;
			this.TimeTextBox.Location = new System.Drawing.Point(54, 22);
			this.TimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TimeTextBox.Name = "TimeTextBox";
			this.TimeTextBox.ReadOnly = true;
			this.TimeTextBox.Size = new System.Drawing.Size(59, 31);
			this.TimeTextBox.TabIndex = 2;
			this.TimeTextBox.TabStop = false;
			this.TimeTextBox.Text = "TIME           ";
			this.TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// DataTitlePanel
			// 
			this.DataTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DataTitlePanel.Controls.Add(this.DataTextBox);
			this.DataTitlePanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.DataTitlePanel.Location = new System.Drawing.Point(572, 0);
			this.DataTitlePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DataTitlePanel.Name = "DataTitlePanel";
			this.DataTitlePanel.Size = new System.Drawing.Size(124, 69);
			this.DataTitlePanel.TabIndex = 4;
			// 
			// DataTextBox
			// 
			this.DataTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DataTextBox.BackColor = System.Drawing.Color.Gainsboro;
			this.DataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataTextBox.Enabled = false;
			this.DataTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataTextBox.HideSelection = false;
			this.DataTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.DataTextBox.Location = new System.Drawing.Point(31, 22);
			this.DataTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DataTextBox.Name = "DataTextBox";
			this.DataTextBox.ReadOnly = true;
			this.DataTextBox.Size = new System.Drawing.Size(61, 31);
			this.DataTextBox.TabIndex = 1;
			this.DataTextBox.Text = "DATA";
			this.DataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// RunItem
			// 
			this.RunItem.CheckOnClick = true;
			this.RunItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RunItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))));
			this.RunItem.Name = "RunItem";
			this.RunItem.Size = new System.Drawing.Size(93, 45);
			this.RunItem.Text = "RUN";
			this.RunItem.Click += new System.EventHandler(this.RunItem_Click);
			// 
			// PauseItem
			// 
			this.PauseItem.Enabled = false;
			this.PauseItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PauseItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))));
			this.PauseItem.Name = "PauseItem";
			this.PauseItem.Size = new System.Drawing.Size(117, 45);
			this.PauseItem.Text = "PAUSE";
			this.PauseItem.Click += new System.EventHandler(this.PauseItem_Click);
			// 
			// HMenuStrip
			// 
			this.HMenuStrip.BackColor = System.Drawing.Color.SkyBlue;
			this.HMenuStrip.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.HMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunItem,
            this.PauseItem});
			this.HMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.HMenuStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.HMenuStrip.Name = "HMenuStrip";
			this.HMenuStrip.Padding = new System.Windows.Forms.Padding(0);
			this.HMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.HMenuStrip.Size = new System.Drawing.Size(1582, 45);
			this.HMenuStrip.TabIndex = 5;
			this.HMenuStrip.Text = "menuStrip1";
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.BackColor = System.Drawing.Color.SkyBlue;
			this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))));
			this.Title.Location = new System.Drawing.Point(12, 0);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(195, 41);
			this.Title.TabIndex = 12;
			this.Title.Text = "RandomNum";
			// 
			// TrackButton
			// 
			this.TrackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TrackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.TrackButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.TrackButton.FlatAppearance.BorderSize = 10;
			this.TrackButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrackButton.ForeColor = System.Drawing.Color.Black;
			this.TrackButton.Location = new System.Drawing.Point(45, 19);
			this.TrackButton.Margin = new System.Windows.Forms.Padding(29, 20, 0, 0);
			this.TrackButton.Name = "TrackButton";
			this.TrackButton.Size = new System.Drawing.Size(139, 37);
			this.TrackButton.TabIndex = 13;
			this.TrackButton.Text = "Auto-Track";
			this.TrackButton.UseVisualStyleBackColor = false;
			this.TrackButton.Click += new System.EventHandler(this.TrackButton_Click);
			// 
			// NavBarPanel
			// 
			this.NavBarPanel.BackColor = System.Drawing.Color.LightSlateGray;
			this.NavBarPanel.Controls.Add(this.TrackButtonPanel);
			this.NavBarPanel.Controls.Add(this.CurrDataPanel);
			this.NavBarPanel.Controls.Add(this.CurrTimePanel);
			this.NavBarPanel.Controls.Add(this.ZoomPanel);
			this.NavBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.NavBarPanel.Location = new System.Drawing.Point(197, 875);
			this.NavBarPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NavBarPanel.Name = "NavBarPanel";
			this.NavBarPanel.Size = new System.Drawing.Size(1385, 78);
			this.NavBarPanel.TabIndex = 2;
			// 
			// TrackButtonPanel
			// 
			this.TrackButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TrackButtonPanel.Controls.Add(this.TrackButton);
			this.TrackButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.TrackButtonPanel.Location = new System.Drawing.Point(510, 0);
			this.TrackButtonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TrackButtonPanel.Name = "TrackButtonPanel";
			this.TrackButtonPanel.Size = new System.Drawing.Size(230, 78);
			this.TrackButtonPanel.TabIndex = 11;
			// 
			// CurrDataPanel
			// 
			this.CurrDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CurrDataPanel.Controls.Add(this.DataLabel);
			this.CurrDataPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.CurrDataPanel.Location = new System.Drawing.Point(250, 0);
			this.CurrDataPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CurrDataPanel.Name = "CurrDataPanel";
			this.CurrDataPanel.Size = new System.Drawing.Size(260, 78);
			this.CurrDataPanel.TabIndex = 10;
			// 
			// DataLabel
			// 
			this.DataLabel.AutoSize = true;
			this.DataLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.DataLabel.Location = new System.Drawing.Point(95, 20);
			this.DataLabel.Name = "DataLabel";
			this.DataLabel.Size = new System.Drawing.Size(79, 36);
			this.DataLabel.TabIndex = 0;
			this.DataLabel.Text = "Data";
			this.DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CurrTimePanel
			// 
			this.CurrTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CurrTimePanel.Controls.Add(this.TimeLabel);
			this.CurrTimePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.CurrTimePanel.Location = new System.Drawing.Point(0, 0);
			this.CurrTimePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CurrTimePanel.Name = "CurrTimePanel";
			this.CurrTimePanel.Size = new System.Drawing.Size(250, 78);
			this.CurrTimePanel.TabIndex = 9;
			// 
			// TimeLabel
			// 
			this.TimeLabel.AutoSize = true;
			this.TimeLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.TimeLabel.Location = new System.Drawing.Point(85, 20);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.Size = new System.Drawing.Size(79, 36);
			this.TimeLabel.TabIndex = 0;
			this.TimeLabel.Text = "Time";
			this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DataStatusListBox
			// 
			this.DataStatusListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataStatusListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataStatusListBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataStatusListBox.FormattingEnabled = true;
			this.DataStatusListBox.ItemHeight = 31;
			this.DataStatusListBox.Location = new System.Drawing.Point(0, 0);
			this.DataStatusListBox.Name = "DataStatusListBox";
			this.DataStatusListBox.ShowScrollbar = false;
			this.DataStatusListBox.Size = new System.Drawing.Size(406, 759);
			this.DataStatusListBox.TabIndex = 0;
			this.DataStatusListBox.SelectedIndexChanged += new System.EventHandler(this.DataStatusListBox_SelectedIndexChanged);
			// 
			// TimeListBox
			// 
			this.TimeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TimeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TimeListBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimeListBox.FormattingEnabled = true;
			this.TimeListBox.ItemHeight = 31;
			this.TimeListBox.Location = new System.Drawing.Point(0, 0);
			this.TimeListBox.Name = "TimeListBox";
			this.TimeListBox.ShowScrollbar = false;
			this.TimeListBox.Size = new System.Drawing.Size(162, 759);
			this.TimeListBox.TabIndex = 0;
			this.TimeListBox.SelectedIndexChanged += new System.EventHandler(this.TimeListBox_SelectedIndexChanged);
			// 
			// DataListBox
			// 
			this.DataListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DataListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataListBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DataListBox.FormattingEnabled = true;
			this.DataListBox.ItemHeight = 31;
			this.DataListBox.Location = new System.Drawing.Point(0, 0);
			this.DataListBox.Name = "DataListBox";
			this.DataListBox.ShowScrollbar = false;
			this.DataListBox.Size = new System.Drawing.Size(122, 759);
			this.DataListBox.TabIndex = 0;
			this.DataListBox.SelectedIndexChanged += new System.EventHandler(this.DataListBox_SelectedIndexChanged);
			// 
			// Forms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1582, 953);
			this.Controls.Add(this.DataDisplayPanel);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.TitleDisplayPanel);
			this.Controls.Add(this.ChartPanel);
			this.Controls.Add(this.NavBarPanel);
			this.Controls.Add(this.VMenuStrip);
			this.Controls.Add(this.HMenuStrip);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(1600, 1000);
			this.Name = "Forms";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
			this.VMenuStrip.ResumeLayout(false);
			this.VMenuStrip.PerformLayout();
			this.DataDisplayPanel.ResumeLayout(false);
			this.DataStatusPanel.ResumeLayout(false);
			this.TimePanel.ResumeLayout(false);
			this.DataPanel.ResumeLayout(false);
			this.ChartPanel.ResumeLayout(false);
			this.ZoomPanel.ResumeLayout(false);
			this.TitleDisplayPanel.ResumeLayout(false);
			this.DataStatusTitlePanel.ResumeLayout(false);
			this.DataStatusTitlePanel.PerformLayout();
			this.DataTimePanel.ResumeLayout(false);
			this.DataTimePanel.PerformLayout();
			this.DataTitlePanel.ResumeLayout(false);
			this.DataTitlePanel.PerformLayout();
			this.HMenuStrip.ResumeLayout(false);
			this.HMenuStrip.PerformLayout();
			this.NavBarPanel.ResumeLayout(false);
			this.TrackButtonPanel.ResumeLayout(false);
			this.CurrDataPanel.ResumeLayout(false);
			this.CurrDataPanel.PerformLayout();
			this.CurrTimePanel.ResumeLayout(false);
			this.CurrTimePanel.PerformLayout();
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
		private	Panel DataDisplayPanel;
		private Panel ChartPanel;
		private	Panel ZoomPanel;
		private	HScrollBar hScrollBar;
		private Button ResetButton;
		private Panel TitleDisplayPanel;
		private	TextBox TimeTextBox;
		private TextBox DataTextBox;
		private ToolStripMenuItem RunItem;
		private ToolStripMenuItem PauseItem;
		private MenuStrip HMenuStrip;
		private Label Title;
		private Button TrackButton;
		private Panel NavBarPanel;
		private TextBox DataStatusTextBox;
		private Panel DataTitlePanel;
		private Panel DataStatusTitlePanel;
		private Panel DataTimePanel;
		private Panel CurrDataPanel;
		private Label DataLabel;
		private Panel CurrTimePanel;
		private Label TimeLabel;
		private Panel TrackButtonPanel;
		private Panel DataStatusPanel;
		private Panel TimePanel;
		private Panel DataPanel;
		private UserDefinedListBox DataStatusListBox;
		private UserDefinedListBox TimeListBox;
		private UserDefinedListBox DataListBox;
	}
}

