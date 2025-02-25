﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MSChartExtensionDemo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public Form1()
        {
            InitializeComponent();
            PlotData();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            chart1.EnableZoomAndPanControls(ChartCursorSelected, ChartCursorMoved,
                zoomChanged,
                new ChartOption()
                {
                    ContextMenuAllowToHideSeries = true,
                    //XAxisPrecision = 4,
                    //YAxisPrecision = 4
                    //,Theme = new DarkTheme()
                });

            chart2.EnableZoomAndPanControls();

            chart3.EnableZoomAndPanControls(ChartCursorSelected, ChartCursorMoved);
        }

        private void PlotData(bool reverse = false)
        {
            chart1.Series[3].ClearPoints();
            const int DataSizeBase = 1000; //Increase this number to plot more points

            //Series 1 used primary YAxis
            Series Ser1 = chart1.Series[0];
            for (int x = DataSizeBase - 1; x != 0; x--)
                Ser1.Points.AddXY(Math.PI * 0.1 * x, Math.Sin(Math.PI * 0.1 * x));

            //Series 2 used secondary YAxis 
            Series Ser2 = chart1.Series[1];
            for (int x = 0; x < (2 * DataSizeBase); x++)
                Ser2.Points.AddXY(0.2 * Math.PI * 0.2 * x, 10 * Math.Cos(Math.PI * 0.2 * x));

            //Series 3 used
            Series Ser3 = chart1.Series[2];
            for (int x = 0; x < (DataSizeBase / 100); x++)
                Ser3.Points.AddXY(Math.PI * 0.1 * x, Math.Sin(Math.PI * 0.1 * x));

            var chartArea = chart1.ChartAreas.First();
            chartArea.AxisX.IsReversed = reverse;
            chartArea.AxisY.IsReversed = reverse;

            Series ptrSeries = chart2.Series[0];
            ptrSeries.Points.AddXY(1, 1);
            ptrSeries.Points.AddXY(2, 2);
            ptrSeries.Points.AddXY(3, 3);

            //Date Time Series
            Series dateSeries = chart3.Series[0];
            DateTime today = DateTime.Today;
            for(int x=0; x < 10; x++)
            {
                dateSeries.Points.AddXY(today.AddDays(x), x);
            }
        }

        private void ClearData()
        {
            foreach (Series ptrSeries in chart1.Series)
                ptrSeries.ClearPoints();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            OnPlotClicked(false);
        }

        private void btnPlotInDescendingOrder_Click(object sender, EventArgs e)
        {
            OnPlotClicked(true);
        }

        private void OnPlotClicked(bool dataAsDescending)
        {
            ClearData();
            StartStopWatch();
            PlotData(dataAsDescending);
            Application.DoEvents();
            CheckStopWatch("Plot datas");
        }

        private void btnClearDataFast_Click(object sender, EventArgs e)
        {
            StartStopWatch();
            ClearData();
            Application.DoEvents();
            CheckStopWatch("Clear datas");
        }

        private void btnClearDataSlow_Click(object sender, EventArgs e)
        {
            StartStopWatch();
            foreach (Series ptrSeries in chart1.Series)
                ptrSeries.Points.Clear();
            Application.DoEvents();
            CheckStopWatch("Clear datas");
        }

        readonly System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

        private void StartStopWatch() { watch.Restart(); }

        private void CheckStopWatch(string message)
        {
            watch.Stop();
            MessageBox.Show(message + " took " + watch.ElapsedMilliseconds.ToString() + "ms");
        }

        private void ChartCursorSelected(Chart sender, ChartCursor e)
        {
            txtChartSelect.Text = e.XFormattedString + ", " + e.YFormattedString; //e.X.ToString("F4") + ", " + e.Y.ToString("F4");
            PointF diff = sender.CursorsDiff();
            txtCursorDelta.Text = diff.X.ToString("F4") + ", " + diff.Y.ToString("F4");
        }

        private void ChartCursorMoved(Chart sender, ChartCursor e)
        {
            txtChartValue.Text = e.XFormattedString + ", " + e.YFormattedString;
        }

        private void zoomChanged(Chart sender)
        {
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.StartsWith("Item"))
            {
                ToolStripMenuItem ptrMenu = (ToolStripMenuItem)e.ClickedItem;
                if (ptrMenu.HasDropDownItems) return;
                MessageBox.Show(ptrMenu.Text);
            }
        }

        private void item11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void item12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test2");
        }

        private void item13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test3");
        }

        private void item14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test4");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            chart1.DrawHorizontalLine(0.5, Color.Green, lineWidth: 3, lineStyle: ChartDashStyle.DashDot);
            chart1.DrawVerticalLine(750, Color.Orange, lineWidth: 3, lineStyle: ChartDashStyle.Dot);
            chart1.DrawRectangle(1000, -0.3, 500, 0.6, Color.Lime, lineWidth: 3);
            chart1.DrawLine(1500, 2000, -1, 1, Color.Pink, lineWidth: 2);
            chart1.DrawLine(1500, 2000, -1, 1, Color.Red, lineWidth: 2, chartArea: chart1.ChartAreas[1]);
            chart1.AddText("Test chart message", 100, 14, Color.Black, textStyle: TextStyle.Shadow, xAxisType: AxisType.Secondary, yAxisType: AxisType.Secondary);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            chart1.Annotations.Clear();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.IsLogarithmic = !chart1.ChartAreas[0].AxisX.IsLogarithmic;
            if (chart1.ChartAreas[0].AxisX.IsLogarithmic)
            {
                chart1.ChartAreas[0].AxisX.Maximum = 1000;
                chart1.ChartAreas[0].AxisX.Minimum = 1;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.Maximum = double.NaN;
                chart1.ChartAreas[0].AxisX.Minimum = double.NaN;
            }
        }

        private void btnUpdateVisibleExtents_Click(object sender, EventArgs e)
        {
        }

        private void btnViewChartExtents_ButtonClick(object sender, EventArgs e)
        {
            RectangleF all = chart1.ChartAreas[0].GetChartAreaBoundary();
            RectangleF visible = chart1.ChartAreas[0].GetChartVisibleAreaBoundary();
            const string fmt = @"All data
{0}

Visible data

{1}";
            MessageBox.Show(string.Format(fmt, all.ToStringWithBoundaries(), visible.ToStringWithBoundaries()), "Extents/boundaries of the data");


        }
    }

    public static class RectangleExtensions
    {
        /// <summary>Returns a string showing left, right, top, and bottom.</summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string ToStringWithBoundaries(this RectangleF value)
        {
            const string fmt = "{{Left={0},Right={1},Top={2},Bottom={3}}}";
            return string.Format(fmt, value.Left, value.Right, value.Top, value.Bottom);
        }
    }

}
