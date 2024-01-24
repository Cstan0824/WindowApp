using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp
{
	public partial class Forms : Form
	{
		//Global declaration
		int temp = 0;
		int ScaleValue = 5;
		int ClickCount = 0;

		//Summary: Form Initialization
		public Forms()
		{
			InitializeComponent();
			List<UserDefinedListBox> list = new List<UserDefinedListBox>()
			{DataListBox,TimeListBox,DataStatusListBox
			};
			foreach (UserDefinedListBox item in list)
			{
				item.MouseWheel += new MouseEventHandler(this.ListBox_OnMouseWheel);
			}
			Chart.ChartAreas[0].AxisX.ScaleView.Size = ScaleValue;
		}

		//Summary: Input the data to graph, Adjust Chart View
		private void timer_Tick(object sender, EventArgs e)
		{
			//DECLARATION
			List<ListBox> list = new List<ListBox>() { DataStatusListBox, TimeListBox, DataListBox };
			Random random = new Random();
			DateTime time = DateTime.Now;
			
			var timer = time.ToString("HH:mm:ss");
			int rnd = random.Next(1, 301);

			int cmp = rnd - temp;
			int PointCount;
			int ListCount;
			temp = rnd;

			//Chart_Series - Green if inc, else red
			string status = cmp > 0 ? "Increase" : "Decrease";
			Color ColorChange = cmp > 0 ? Color.Green : Color.Red;


			//Chart - Add, Points Color Display
			Chart.Series[0].Points.AddXY(timer, rnd);
			PointCount = Chart.Series[0].Points.Count;
			Chart.Series[0].Points[PointCount - 1].Color = ColorChange;
			Chart.Series[0].Points[PointCount - 1].MarkerBorderColor = Color.Green;
			if (PointCount >= 2) Chart.Series[0].Points[PointCount - 2].MarkerBorderColor = Color.Black;
			

			//Label - Display
			DataLabel.Text = rnd.ToString();
			TimeLabel.Text = time.ToString("HH:mm");

			//List Box - Add
			DataStatusListBox.Items.Add(status + " by " + Math.Abs(cmp));
			TimeListBox.Items.Add(timer);
			DataListBox.Items.Add(rnd);

			//Auto-Track by select latest data
			if (ClickCount % 2 == 0)
			{
				Chart.ChartAreas[0].AxisX.ScaleView.Position = PointCount - ScaleValue;
				ListCount = DataListBox.Items.Count;
				foreach (ListBox box in list)
				{
					box.TopIndex = ListCount - 1;
					box.SelectedIndex = ListCount - 1;

				}
			}
		}

		//Summary: Display Chart & Data Status Panel
		private void IndexItem_Click(object sender, EventArgs e)
		{
			PanelControlView(new List<Panel> { ChartPanel, ZoomPanel,DataDisplayPanel, TitleDisplayPanel });

			ItemControl(IndexItem);
			ChartPanel.Dock = DockStyle.Right;
		}

		//Summary: Display Data Status Panel
		private void DataStatusItem_Click(object sender, EventArgs e)
		{
			PanelControlView(new List<Panel> { DataDisplayPanel,TitleDisplayPanel });
			ItemControl(DataStatusItem);
		}

		//Summary: Display Chart Panel
		private void LineGraphItem_Click(object sender, EventArgs e)
		{
			PanelControlView(new List<Panel> { ChartPanel,ZoomPanel });
			ItemControl(LineGraphItem);
			ChartPanel.Dock = DockStyle.Fill;
		}

		//Summary: Run Chart
		private void RunItem_Click(object sender, EventArgs e)
		{
			if (!timer.Enabled)
			{
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
				timer.Stop();
				PauseItem.Enabled = false;
				RunItem.Enabled = true;				
			}
		}

		//Summary: Zoom In / Zoom Out
		private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			int PreValue = ScaleValue;
			int CurrValue = hScrollBar.Value;
			ChartPositionControl(PreValue, CurrValue, 1, CurrValue, nameof(hScrollBar));

			ScaleValue = hScrollBar.Value;
			Chart.ChartAreas[0].AxisX.ScaleView.Size = ScaleValue;
		}

		//Summary: Reset the Chart View to default View
		private void ResetButton_Click(object sender, EventArgs e)
		{
			int CurrValue = hScrollBar.Value;
			int Adjustment = Math.Abs(5 - ScaleValue);
			ChartPositionControl(5, CurrValue, Adjustment, 5, nameof(ResetButton));

			ScaleValue = 5;
			Chart.ChartAreas[0].AxisX.ScaleView.Size = ScaleValue;
			hScrollBar.Value = ScaleValue;
			
		}

		//Summary: Odd Num(Red) will close the track, Even Num(Green) will generate the track
		private void TrackButton_Click(object sender, EventArgs e)
		{
			ClickCount++;
			TrackButton.BackColor = (ClickCount % 2 == 0) ? Color.Green : Color.Red;
		}


		//Summary: Selected Index Adjustment
		private void DataStatusListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			TimeListBox.SelectedIndex = DataListBox.SelectedIndex = DataStatusListBox.SelectedIndex;
		}

		private void TimeListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataListBox.SelectedIndex = DataStatusListBox.SelectedIndex = TimeListBox.SelectedIndex;
		}

		private void DataListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ViewAdjust(DataListBox);
			DataStatusListBox.SelectedIndex = TimeListBox.SelectedIndex = DataListBox.SelectedIndex;
		}

		//Summary: ListBoxs View Adjustment
		private void ListBox_OnMouseWheel(object sender, MouseEventArgs e)
		{
			List<UserDefinedListBox> list = new List<UserDefinedListBox>()
			{DataListBox,TimeListBox,DataStatusListBox };
			foreach (UserDefinedListBox item in list)
			{
				item.TopIndex = (e.Delta < 0) 
					? 
					item.TopIndex + 2 
					:
					item.TopIndex - 2
					;
			}

		}


		//Summary: Control's View Adjustment
		private void PanelControlView(List<Panel> panels)
		{
			List<Panel> listPanel = new List<Panel>() { ZoomPanel, DataDisplayPanel, ChartPanel, TitleDisplayPanel };
			foreach (Panel panel in listPanel)
			{
				panel.Visible = (panels.Contains(panel)) ? true : false;
			}
		}
		private void ViewAdjust(ListBox listbox)
		{
			Chart.ChartAreas[0].AxisX.ScaleView.Position = (listbox.SelectedIndex < ScaleValue)
				?
				1
				:
				listbox.SelectedIndex - ScaleValue + 1;
		}
		private void ItemControl(ToolStripMenuItem Items)
		{
			foreach (ToolStripMenuItem item in new ToolStripMenuItem[] { IndexItem, DataStatusItem, LineGraphItem })
			{
				item.BackColor = (item.Enabled = (item == Items) ? false : true)
					? Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(82)))), ((int)(((byte)(123)))))
					: Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(223)))), ((int)(((byte)(235)))))
					;
				;
			}
		}
		private void ChartPositionControl(int pre,int curr,int AdjustValue,int threshold,string ItemType)
		{
			if (Chart.ChartAreas[0].AxisX.ScaleView.Position == 1)
			{
				Chart.ChartAreas[0].AxisX.ScaleView.Position = 1;
			}
			else if (Chart.ChartAreas[0].AxisX.ScaleView.Position >= Chart.Series[0].Points.Count - threshold - 3)
			{
				Chart.ChartAreas[0].AxisX.ScaleView.Position = Chart.Series[0].Points.Count - threshold + 1;
			}
			else if (pre != curr)
			{
				switch (ItemType)
				{
					case "ResetButton":
						ChartPositionControl_Reset(pre, curr, AdjustValue);
						break;
					case "hScrollBar":
						ChartPositionControl_Scroll(pre, curr, AdjustValue);
						break;
					default:
						break;
				}
			}
			
		}
		//Summary:
		//Zoom-In: Add Position Value 
		//Zoom-Out: Sub Position Value
		private void ChartPositionControl_Reset(int pre, int curr, int AdjustValue)
		{
			Chart.ChartAreas[0].AxisX.ScaleView.Position = (pre < curr)
					?//Zoom Out to Normal | Zoom-In
					Chart.ChartAreas[0].AxisX.ScaleView.Position + AdjustValue
					://Zoom In to Normal | Zoom-Out
					Chart.ChartAreas[0].AxisX.ScaleView.Position - AdjustValue
					;
		}
		private void ChartPositionControl_Scroll(int pre,int curr,int AdjustValue)
		{
			Chart.ChartAreas[0].AxisX.ScaleView.Position = (pre < curr)
					?//Normal to Zoom Out |Zoom-Out
					Chart.ChartAreas[0].AxisX.ScaleView.Position - AdjustValue
					://Normal to Zoom In | Zoom-In
					Chart.ChartAreas[0].AxisX.ScaleView.Position + AdjustValue
					;
		}
	}

	//Summary: Defined a new custom List Box that Remove the Vertical Scroll Bar
	public class UserDefinedListBox : ListBox
	{
		private bool mShowScroll;
		
		protected override CreateParams CreateParams
		{
			//Remove Vertical Scroll if ShowScrollbar is false
			get
			{
				CreateParams cp = base.CreateParams;
				if (!mShowScroll)
					cp.Style = cp.Style & ~0x200000;
				return cp;
			}
		}

		public bool ShowScrollbar
		{
			get { return mShowScroll; }
			//Proform changes to control if the ShowScrollbar is different
			set
			{
				if (value != mShowScroll)
				{
					mShowScroll = value;
					if (IsHandleCreated)
						RecreateHandle();
				}
			}
		}
	}
}
