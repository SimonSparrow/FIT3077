using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hopeful.MelborneWeatherService;
using System.Collections;

namespace Hopeful
{
	public partial class CfrmWeather : Form
	{
		public CheckBox check;
        private ArrayList controlCollection = new ArrayList();

        private MelbourneWeather2PortTypeClient client = new MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");
        private GetData getData;
        private GetLocation observer;
        private WeatherService soapService;
        public CfrmWeather()
		{
			InitializeComponent();
		}

		private void CfrmWeather_Load(object sender, EventArgs e)
		{
            getData = new GetData();
            soapService = new SOAPService(client);
			foreach (string location in soapService.getLocation())
			{
				cmbLocations.Items.Add(location);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
            string[] rain = new string[2]{"", ""};
            string[] temp = new string[2] { "", "" }; 
			string location = cmbLocations.SelectedItem.ToString();
            if (ckbRainfall.Checked)
                rain = soapService.getRainfall(location);
            if (ckbTemp.Checked)
                temp = soapService.getTemperature(location);

            observer = new GetLocation(getData);
            observer.update(location, rain, temp);
            getData.RegisterObserver(observer);
			tableAdd(observer);
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			tableRemove();
		}

		private void tmrUpdate_Tick(object sender, EventArgs e)
		{
			getData.NotifyObserver();
		}


		private void tableRemove()
		{
            int i;
            foreach(CheckBox check in tlpLocations.Controls)
            {
                if (check.Checked)
                {
                    i = tlpLocations.Controls.GetChildIndex(check);
                    observer = (GetLocation)getData.observers[i];
                    getData.RemoveObserver(observer);
                    tlpLocations.Controls.Remove(check);

                }
            }
            test();
        }

        private void tableAdd(GetLocation location)
        {
            //this.check.Equals(check);
            check = new CheckBox();
            check.AutoSize = true;
            tlpLocations.Visible = true;
            check.Name = location.location;
            check.Text = location.location;
            if (ckbRainfall.Checked)
                check.Text += "\nRainfall: " + location.rainfall[1];
            if (ckbTemp.Checked)
                check.Text += "\nTemperature: " + location.temperature[1];
            tlpLocations.Controls.Add(check);
        }
	}
}

