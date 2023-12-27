using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp
{
	public partial class Forms : Form
	{
		//GLOBAL DECLARATION
		int temp = 0;
		int ScaleValue = 5;
		Screen resolution = Screen.PrimaryScreen;

		//Summary: Initialize the form and Display Index Page By Default
		public Forms()
		{
			InitializeComponent();
			Chart.ChartAreas[0].AxisX.ScaleView.Size = ScaleValue;
			ResolutionAdjust(DataPanel, listBox1, 34, 72, 13, 18);
			ResolutionAdjust(ChartPanel, Chart, 43, 80, 50, 13);
			ResolutionAdjust(TitlePanel, 34, 5, 13, 13);
			listBox1.Visible = true;

		}

		//Summary: Input the data to graph, Adjust Chart View
		private void timer_Tick(object sender, EventArgs e)
		{
			//DECLARATION
			Random random = new Random();
			DateTime time = DateTime.Now;
			
			var timer = time.ToString("HH:mm:ss");
			int rnd = random.Next(1, 301);

			//Compare the previous value
			int cmp = rnd - temp; 
			//GREEN if INC,RED if DEC
			string status = cmp > 0 ? "INCREASE" : "DECREASE";
			Color ColorChange = cmp > 0 ? Color.Green : Color.Red;

			int PointCount;
			int ListCount;
			temp = rnd;

			//CHART - Add, Adjust View
			Chart.Series[0].Points.AddXY(timer, rnd);
			PointCount = Chart.Series[0].Points.Count;
			Chart.ChartAreas[0].AxisX.ScaleView.Position = PointCount - ScaleValue;
			Chart.Series[0].Points[PointCount - 1].Color = ColorChange;
		
			//LIST BOX - Add, Adjust the selected index 
			listBox1.Items.AddRange(new object[] 
			{status + " BY " + Math.Abs(cmp) + "\t\t   " + timer + "\t      " + rnd});

			listBox2.Items.AddRange(new object[] 
			{status + " BY " + Math.Abs(cmp) + "\t\t\t\t\t" + timer + "\t   " + rnd });

			ListCount = listBox1.Items.Count;

			listBox1.TopIndex = ListCount  - 1;
			listBox1.SelectedIndex = ListCount - 1;

			listBox2.TopIndex = ListCount - 1;
			listBox2.SelectedIndex = ListCount - 1;
		}

		//Summary: Display Index and related element
		private void IndexItem_Click(object sender, EventArgs e)
		{
			PageLabel.Text = "INDEX";
			
			ResolutionAdjust(DataPanel, listBox1, 34, 80, 13, 18);
			ResolutionAdjust(ChartPanel, Chart, 43, 80, 50, 13);
			ResolutionAdjust(TitlePanel, 34, 5, 13, 13);

			ZoomPanel.Visible = true;
			listBox1.Visible = true;

			foreach (ToolStripMenuItem item in new ToolStripMenuItem[] { IndexItem, DataStatusItem, LineGraphItem })
				item.Enabled = item == IndexItem ? false : true;
			
		}

		//Summary: Display Data Status and related element
		private void DataStatusItem_Click(object sender, EventArgs e)
		{
			PageLabel.Text = "DATA STATUS";
			

			ResolutionAdjust(DataPanel, listBox2, 80, 80, 13, 18);
			ResolutionAdjust(TitlePanel, 80, 5, 13, 13);

			ChartPanel.Visible = false;
			ZoomPanel.Visible = false;

			foreach (ToolStripMenuItem item in new ToolStripMenuItem[] { IndexItem, DataStatusItem, LineGraphItem })
				item.Enabled = item == DataStatusItem ? false : true;
			
		}

		//Summary: Display Line Graph and related element
		private void LineGraphItem_Click(object sender, EventArgs e)
		{
			PageLabel.Text = "LINE GRAPH";

			ResolutionAdjust(ChartPanel, Chart, 80, 80, 13, 13);

			ZoomPanel.Visible = true;
			DataPanel.Visible = false;
			TitlePanel.Visible = false;

			foreach (ToolStripMenuItem item in new ToolStripMenuItem[] { IndexItem, DataStatusItem, LineGraphItem })
				item.Enabled = item == LineGraphItem ? false : true;
			
		}

		//Summary: Close Program
		private void ExitItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//Summary: Ran Chart
		private void RunItem_Click(object sender, EventArgs e)
		{
			if (!timer.Enabled)
			{
				StatusLabel.Text = "PROGRAM : RUNNING";
				timer.Start();
				RunItem.Enabled = false;
				PauseItem.Enabled = true;
			}
		}

		//Summary: Pause Chart
		private void PauseItem_Click(object sender, EventArgs e)
		{
			if (timer.Enabled)
			{
				StatusLabel.Text = "PROGRAM : PAUSED";
				timer.Stop();
				PauseItem.Enabled = false;
				RunItem.Enabled = true;
			}
		}

		//Summary: Zoom In / Zoom Out
		private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			ScaleValue = hScrollBar.Value;
			Chart.ChartAreas[0].AxisX.ScaleView.Size = ScaleValue;
			ViewAdjust(listBox1);
		}

		//Summary: Reset the Chart View to default View
		private void ResetButton_Click(object sender, EventArgs e)
		{
			ScaleValue = 5;
			Chart.ChartAreas[0].AxisX.ScaleView.Size = 5;
			hScrollBar.Value = 5;
			ViewAdjust(listBox1);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ViewAdjust(listBox1);
			listBox2.SelectedIndex = listBox1.SelectedIndex;
			listBox1.TopIndex = listBox1.SelectedIndex;
			listBox2.TopIndex = listBox1.TopIndex;
		}
		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			ViewAdjust(listBox2);
			listBox1.SelectedIndex = listBox2.SelectedIndex;
			listBox2.TopIndex = listBox2.SelectedIndex;
			listBox1.TopIndex = listBox2.TopIndex;
		}
		//Summary: Adjustment of Resolution and View for Panel/element
		public void ResolutionAdjust<T>(Panel panel, T element,int WSizePercent,int HSizePercent,int WLocatePercent,int HLocatePercent) 
			where T : Control
		{
			panel.Size = new Size((int)(resolution.Bounds.Width * WSizePercent / 100.0),
				(int)(resolution.Bounds.Height * HSizePercent / 100.0));

			panel.Location = new Point((int)(resolution.Bounds.Width * WLocatePercent/100.0),
				(int)(resolution.Bounds.Height * HLocatePercent / 100.0));

			panel.Visible = true;

			element.Size = panel.Size;
			element.Location = new Point(0, 0);
			
			foreach (Control item in new Control[] { listBox1, listBox2, Chart })
				item.Visible = (item != element) ? false : true;
		}
		public void ResolutionAdjust(Panel panel, int WSizePercent, int HSizePercent, int WLocatePercent, int HLocatePercent)
		{
			panel.Size = new Size((int)(resolution.Bounds.Width * WSizePercent / 100.0),
				(int)(resolution.Bounds.Height * HSizePercent / 100.0));

			panel.Location = new Point((int)(resolution.Bounds.Width * WLocatePercent / 100.0),
				(int)(resolution.Bounds.Height * HLocatePercent / 100.0));

			panel.Visible = true;
		}

		public void ViewAdjust(ListBox listbox)
		{
			Chart.ChartAreas[0].AxisX.ScaleView.Position = (listbox.SelectedIndex < ScaleValue)
				?
				1
				:
				listbox.SelectedIndex - ScaleValue + 1;
		}

	}
}
