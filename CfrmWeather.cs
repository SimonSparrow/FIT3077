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
		public Label labelR;//new
		public Label labelT;//new
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
			tmrUpdate.Start();
			tlpLocations.Visible = true;
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
			//this.check.Equals(check);
			//this.check = new CheckBox();
			this.check = check;
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
				//tlpLocations.Controls.Remove();
				tlpLocations.GetCellPosition(check);
				tlpLocations.Controls.Remove(check);
				tlpLocations.Controls.Remove(labelR);//new
				tlpLocations.Controls.Remove(labelT);//new
				//tlpLocations.Dispose();
				tlpLocations.RowCount = data.observers.Count;
			}
		}

		private void tableAdd()
		{
			//this.check.Equals(check);
			check = new CheckBox();
			labelR = new Label();//new
			labelT = new Label();//new
			check.AutoSize = true;
			labelR.AutoSize = true;
			labelT.AutoSize = true;
			tlpLocations.Visible = true;

			foreach (GetLocation location in data.observers)
			{
				check.Text = location.location;
				//check.Text.Equals(tlpLocations);
				tlpLocations.Controls.Add(check);
			}

			//rainfall and temperature
			if (ckbRainfall.Checked == true && ckbTemp.Checked == true)
			{
				foreach (GetLocation location in data.observers)
				{
					labelR.Text = "Rainfall:" + location.getRainfall();
					labelT.Text = "Temperature:" + location.getTemperature();
					tlpLocations.Controls.Add(labelR);
					tlpLocations.Controls.Add(labelT);
					labelR.Visible = true;
					labelT.Visible = true;
				}
			}

			//rainfall
			if (ckbRainfall.Checked == true)
			{
				foreach (GetLocation location in data.observers)
				{
					labelR.Text = "Rainfall:" + location.getRainfall();
					tlpLocations.Controls.Add(labelR);
				}
			}
			else
			{
				labelR.Visible = true;
			}

			//temperature
			if (ckbTemp.Checked == true)
			{
				foreach (GetLocation location in data.observers)
				{
					labelT.Text = "Temperature:" + location.getTemperature();
					tlpLocations.Controls.Add(labelT);
				}
			}
			else
			{
				labelT.Visible = true;
			}
		}

		private void ckbRainfall_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void ckbTemp_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void tlpLocations_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			foreach (GetLocation location in data.observers)
			{
					tlpLocations.Controls.Remove(check);
					tlpLocations.Controls.Remove(labelR);//new
					tlpLocations.Controls.Remove(labelT);//new
					tlpLocations.RowCount = data.observers.Count;
					//tlpLocations.Visible = false;
					tlpLocations.Dispose();
					//tlpLocations.Remove(tlpLocations);
					//tlpLocations.Visible.Equals(false);
					break;
			}
		}
	}
}

