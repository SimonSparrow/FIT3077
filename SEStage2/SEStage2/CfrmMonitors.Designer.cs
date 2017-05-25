namespace SEStage2
{
    partial class CfrmMonitors
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLocation = new System.Windows.Forms.Label();
            this.chtWeather = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpRads = new System.Windows.Forms.GroupBox();
            this.radLive = new System.Windows.Forms.RadioButton();
            this.radTimeLapse = new System.Windows.Forms.RadioButton();
            this.lblLapse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtWeather)).BeginInit();
            this.grpRads.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(13, 13);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location";
            // 
            // chtWeather
            // 
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.Name = "WeatherData";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 73.2504F;
            chartArea1.Position.X = 3F;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 73.2504F;
            chartArea2.Position.X = 3F;
            chartArea2.Visible = false;
            this.chtWeather.ChartAreas.Add(chartArea1);
            this.chtWeather.ChartAreas.Add(chartArea2);
            this.chtWeather.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Live";
            legend2.Enabled = false;
            legend2.Name = "Lapse";
            this.chtWeather.Legends.Add(legend1);
            this.chtWeather.Legends.Add(legend2);
            this.chtWeather.Location = new System.Drawing.Point(0, 111);
            this.chtWeather.Name = "chtWeather";
            this.chtWeather.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "WeatherData";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Live";
            series1.LegendText = "Temperature in °C";
            series1.Name = "Temperature";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 2;
            series2.ChartArea = "WeatherData";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Live";
            series2.LegendText = "Rainfall in mm";
            series2.Name = "Rainfall";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero";
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "{0.00}";
            series3.Legend = "Lapse";
            series3.LegendText = "Temperature in °C";
            series3.Name = "LiveTemp";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Lapse";
            series4.LegendText = "Rainfall in mm";
            series4.Name = "LiveRain";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chtWeather.Series.Add(series1);
            this.chtWeather.Series.Add(series2);
            this.chtWeather.Series.Add(series3);
            this.chtWeather.Series.Add(series4);
            this.chtWeather.Size = new System.Drawing.Size(632, 283);
            this.chtWeather.TabIndex = 1;
            // 
            // grpRads
            // 
            this.grpRads.Controls.Add(this.radTimeLapse);
            this.grpRads.Controls.Add(this.radLive);
            this.grpRads.Location = new System.Drawing.Point(420, 5);
            this.grpRads.Name = "grpRads";
            this.grpRads.Size = new System.Drawing.Size(200, 75);
            this.grpRads.TabIndex = 2;
            this.grpRads.TabStop = false;
            this.grpRads.Text = "Chart Display";
            // 
            // radLive
            // 
            this.radLive.AutoSize = true;
            this.radLive.Checked = true;
            this.radLive.Location = new System.Drawing.Point(7, 20);
            this.radLive.Name = "radLive";
            this.radLive.Size = new System.Drawing.Size(68, 17);
            this.radLive.TabIndex = 0;
            this.radLive.TabStop = true;
            this.radLive.Text = "LiveData";
            this.radLive.UseVisualStyleBackColor = true;
            this.radLive.CheckedChanged += new System.EventHandler(this.radLive_CheckedChanged);
            // 
            // radTimeLapse
            // 
            this.radTimeLapse.AutoSize = true;
            this.radTimeLapse.Location = new System.Drawing.Point(7, 44);
            this.radTimeLapse.Name = "radTimeLapse";
            this.radTimeLapse.Size = new System.Drawing.Size(77, 17);
            this.radTimeLapse.TabIndex = 1;
            this.radTimeLapse.Text = "TimeLapse";
            this.radTimeLapse.UseVisualStyleBackColor = true;
            this.radTimeLapse.CheckedChanged += new System.EventHandler(this.radLive_CheckedChanged);
            // 
            // lblLapse
            // 
            this.lblLapse.AutoSize = true;
            this.lblLapse.Location = new System.Drawing.Point(13, 13);
            this.lblLapse.Name = "lblLapse";
            this.lblLapse.Size = new System.Drawing.Size(44, 13);
            this.lblLapse.TabIndex = 3;
            this.lblLapse.Text = "location";
            // 
            // CfrmMonitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 394);
            this.Controls.Add(this.lblLapse);
            this.Controls.Add(this.grpRads);
            this.Controls.Add(this.chtWeather);
            this.Controls.Add(this.lblLocation);
            this.Name = "CfrmMonitors";
            this.Text = "CfrmMonitors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CfrmMonitors_FormClosing);
            this.Load += new System.EventHandler(this.CfrmMonitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtWeather)).EndInit();
            this.grpRads.ResumeLayout(false);
            this.grpRads.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtWeather;
        private System.Windows.Forms.GroupBox grpRads;
        private System.Windows.Forms.RadioButton radTimeLapse;
        private System.Windows.Forms.RadioButton radLive;
        private System.Windows.Forms.Label lblLapse;
    }
}