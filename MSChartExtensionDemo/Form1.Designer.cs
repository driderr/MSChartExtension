﻿namespace MSChartExtensionDemo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPlot = new System.Windows.Forms.ToolStripSplitButton();
            this.btnPlotInDescendingOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearDataFast = new System.Windows.Forms.ToolStripButton();
            this.btnClearDataSlow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnViewChartExtents = new System.Windows.Forms.ToolStripSplitButton();
            this.btnUpdateVisibleExtents = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtChartValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtChartSelect = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCursorDelta = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblZoomExtents = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.Title = "Y";
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ContextMenuStrip = this.contextMenuStrip1;
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 3;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Blue;
            series2.MarkerColor = System.Drawing.Color.Blue;
            series2.MarkerSize = 3;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.ChartArea = "ChartArea2";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series3.YValuesPerPoint = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(923, 473);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "Title1";
            this.chart1.Titles.Add(title1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.item2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item11ToolStripMenuItem,
            this.item12ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item13ToolStripMenuItem,
            this.item14ToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.itemToolStripMenuItem.Text = "Item 1";
            // 
            // item11ToolStripMenuItem
            // 
            this.item11ToolStripMenuItem.Name = "item11ToolStripMenuItem";
            this.item11ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.item11ToolStripMenuItem.Text = "Item 1.1";
            this.item11ToolStripMenuItem.Click += new System.EventHandler(this.item11ToolStripMenuItem_Click);
            // 
            // item12ToolStripMenuItem
            // 
            this.item12ToolStripMenuItem.Name = "item12ToolStripMenuItem";
            this.item12ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.item12ToolStripMenuItem.Text = "Item 1.2";
            this.item12ToolStripMenuItem.Click += new System.EventHandler(this.item12ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // item13ToolStripMenuItem
            // 
            this.item13ToolStripMenuItem.Name = "item13ToolStripMenuItem";
            this.item13ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.item13ToolStripMenuItem.Text = "Item 1.3";
            this.item13ToolStripMenuItem.Click += new System.EventHandler(this.item13ToolStripMenuItem_Click);
            // 
            // item14ToolStripMenuItem
            // 
            this.item14ToolStripMenuItem.Name = "item14ToolStripMenuItem";
            this.item14ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.item14ToolStripMenuItem.Text = "Item 1.4";
            this.item14ToolStripMenuItem.Click += new System.EventHandler(this.item14ToolStripMenuItem_Click);
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlot,
            this.btnClearDataFast,
            this.btnClearDataSlow,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.btnViewChartExtents});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(937, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPlot
            // 
            this.btnPlot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPlot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlotInDescendingOrder});
            this.btnPlot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(71, 22);
            this.btnPlot.Text = "Plot Data";
            this.btnPlot.ButtonClick += new System.EventHandler(this.btnPlot_Click);
            // 
            // btnPlotInDescendingOrder
            // 
            this.btnPlotInDescendingOrder.Name = "btnPlotInDescendingOrder";
            this.btnPlotInDescendingOrder.Size = new System.Drawing.Size(182, 22);
            this.btnPlotInDescendingOrder.Text = "In &Descending Order";
            this.btnPlotInDescendingOrder.Click += new System.EventHandler(this.btnPlotInDescendingOrder_Click);
            // 
            // btnClearDataFast
            // 
            this.btnClearDataFast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearDataFast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearDataFast.Name = "btnClearDataFast";
            this.btnClearDataFast.Size = new System.Drawing.Size(97, 22);
            this.btnClearDataFast.Text = "Clear Data (Fast)";
            this.btnClearDataFast.Click += new System.EventHandler(this.btnClearDataFast_Click);
            // 
            // btnClearDataSlow
            // 
            this.btnClearDataSlow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearDataSlow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearDataSlow.Name = "btnClearDataSlow";
            this.btnClearDataSlow.Size = new System.Drawing.Size(101, 22);
            this.btnClearDataSlow.Text = "Clear Data (Slow)";
            this.btnClearDataSlow.Click += new System.EventHandler(this.btnClearDataSlow_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton1.Text = "Annotation Test";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(106, 22);
            this.toolStripButton2.Text = "Clear Annotations";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "LogTest";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnViewChartExtents
            // 
            this.btnViewChartExtents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnViewChartExtents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdateVisibleExtents});
            this.btnViewChartExtents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewChartExtents.Name = "btnViewChartExtents";
            this.btnViewChartExtents.Size = new System.Drawing.Size(88, 22);
            this.btnViewChartExtents.Text = "View &Extents";
            this.btnViewChartExtents.ToolTipText = "Extents are the boundaries (left, right, top, bottom) of the data";
            this.btnViewChartExtents.ButtonClick += new System.EventHandler(this.btnViewChartExtents_ButtonClick);
            // 
            // btnUpdateVisibleExtents
            // 
            this.btnUpdateVisibleExtents.Name = "btnUpdateVisibleExtents";
            this.btnUpdateVisibleExtents.Size = new System.Drawing.Size(189, 22);
            this.btnUpdateVisibleExtents.Text = "Update &Visible Extents";
            this.btnUpdateVisibleExtents.ToolTipText = "These are shown in the status bar at the bottom of the screen.";
            this.btnUpdateVisibleExtents.Click += new System.EventHandler(this.btnUpdateVisibleExtents_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtChartValue,
            this.txtChartSelect,
            this.txtCursorDelta,
            this.lblZoomExtents});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(937, 24);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtChartValue
            // 
            this.txtChartValue.AutoSize = false;
            this.txtChartValue.AutoToolTip = true;
            this.txtChartValue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtChartValue.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.txtChartValue.Name = "txtChartValue";
            this.txtChartValue.Size = new System.Drawing.Size(173, 19);
            this.txtChartValue.Text = "Hover mouse to see point here";
            this.txtChartValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtChartSelect
            // 
            this.txtChartSelect.AutoSize = false;
            this.txtChartSelect.AutoToolTip = true;
            this.txtChartSelect.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtChartSelect.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.txtChartSelect.Name = "txtChartSelect";
            this.txtChartSelect.Size = new System.Drawing.Size(133, 19);
            this.txtChartSelect.Text = "Select to see point here";
            this.txtChartSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCursorDelta
            // 
            this.txtCursorDelta.AutoSize = false;
            this.txtCursorDelta.AutoToolTip = true;
            this.txtCursorDelta.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.txtCursorDelta.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.txtCursorDelta.Name = "txtCursorDelta";
            this.txtCursorDelta.Size = new System.Drawing.Size(133, 19);
            this.txtCursorDelta.Text = "Cursor Delta";
            this.txtCursorDelta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZoomExtents
            // 
            this.lblZoomExtents.AutoSize = false;
            this.lblZoomExtents.AutoToolTip = true;
            this.lblZoomExtents.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblZoomExtents.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.lblZoomExtents.Name = "lblZoomExtents";
            this.lblZoomExtents.Size = new System.Drawing.Size(230, 19);
            this.lblZoomExtents.Text = "Zoom to see visible extents here";
            this.lblZoomExtents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 505);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(929, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Line Chart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(929, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(6, 6);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(929, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart3.Name = "chart3";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(929, 487);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MSChartExtension Demo";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClearDataSlow;
        private System.Windows.Forms.ToolStripButton btnClearDataFast;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtChartValue;
        private System.Windows.Forms.ToolStripStatusLabel txtChartSelect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem item13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripStatusLabel lblZoomExtents;
        private System.Windows.Forms.ToolStripSplitButton btnPlot;
        private System.Windows.Forms.ToolStripMenuItem btnPlotInDescendingOrder;
        private System.Windows.Forms.ToolStripSplitButton btnViewChartExtents;
        private System.Windows.Forms.ToolStripMenuItem btnUpdateVisibleExtents;
        private System.Windows.Forms.ToolStripStatusLabel txtCursorDelta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}

