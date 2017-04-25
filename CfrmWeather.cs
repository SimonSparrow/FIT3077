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

namespace Hopeful
{
    public partial class CfrmWeather : Form
    {
        GetData data = new GetData();
        public CheckBox check;
        public Label label;
        public CfrmWeather()
        {
            InitializeComponent();
        }

        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            MelbourneWeather2PortTypeClient client = new MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");
            
            string location = cmbLocations.SelectedItem.ToString();
            GetLocation local = new GetLocation(client, location);
            data.RegisterObserver(local);
            
        }

        private void CfrmWeather_Load(object sender, EventArgs e)
        {
            MelbourneWeather2PortTypeClient client = new MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");
            GetLocation locations = new GetLocation(client);
            //tmrUpdate.Start();
            tlpLocations.Visible = false;
            foreach (string location in locations.Locations())
            {
                cmbLocations.Items.Add(location);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MelbourneWeather2PortTypeClient client = new MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");

            string location = cmbLocations.SelectedItem.ToString();
            GetLocation local = new GetLocation(client, location);
            data.RegisterObserver(local);
            tableAdd();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tableRemove();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            data.NotifyObserver();
        }

        private void tableRemove()
        {
            if (check.Checked)
            {
                foreach (GetLocation location in data.observers)
                {
                    if (check.Text.Equals(location.location))
                    {
                        data.RemoveObserver(location);
                        break;
                    }

                }
                tlpLocations.Controls.Remove(check);
                tlpLocations.Controls.Remove(label);
                tlpLocations.RowCount = data.observers.Count;              
            }
        }

        private void tableAdd()
        {
            check = new CheckBox();
            label = new Label();
            check.AutoSize = true;
            label.AutoSize = true;
            tlpLocations.Visible = false;
            foreach (GetLocation location in data.observers)
            {
                check.Text = location.location;
                tlpLocations.Controls.Add(check);
            }
            foreach (GetLocation location in data.observers)
            {
                label.Text = location.getRainfall() + "\n" + location.getTemperature();
                tlpLocations.Controls.Add(label);
            }
            tlpLocations.Visible = true;
        }
    }
}
