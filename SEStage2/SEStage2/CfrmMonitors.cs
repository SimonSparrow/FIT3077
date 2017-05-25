using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEStage2.MelborneWeatherService;
using SEStage2.MelborneTimeLapse;
using System.Collections;

namespace SEStage2
{
    public partial class CfrmMonitors : Form
    {
        SEStage2.Form1 info = new Form1();
        public CfrmMonitors()
        {
            InitializeComponent();
        }

        private void CfrmMonitors_Load(object sender, EventArgs e)
        {
            chartChange();
        }

        public Label getLblLocation()
        {
            return lblLocation;
        }

        public Label getLblLapse()
        {
            return lblLapse;
        }
        public System.Windows.Forms.DataVisualization.Charting.Chart getChart()
        {
            return chtWeather;
        }

        private void CfrmMonitors_FormClosing(object sender, FormClosingEventArgs e)
        {
           //info.removeMonitor(this);
        }

        public RadioButton getRadLive()
        {
            return radLive;
        }

        private void radLive_CheckedChanged(object sender, EventArgs e)
        {
            chartChange();
            info.displayMonitors();
        }

        private void chartChange()
        {
            if (radLive.Checked)
            {
                chtWeather.ChartAreas[0].Visible = true;
                chtWeather.ChartAreas[1].Visible = false;
                lblLapse.Visible = false;
                lblLocation.Visible = true;
            }
            else
            {
                chtWeather.ChartAreas[0].Visible = false;
                chtWeather.ChartAreas[1].Visible = true;
                lblLapse.Visible = true;
                lblLocation.Visible = false;
            }
        }
    }
}
