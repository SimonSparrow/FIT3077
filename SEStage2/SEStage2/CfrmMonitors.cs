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
            
        }

        public Label getLblLocation()
        {
            return lblLocation;
        }       
    }
}
