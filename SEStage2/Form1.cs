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
    public partial class Form1 : Form
    {
        private MelbourneWeather2PortTypeClient client = new MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");
        private MelbourneWeatherTimeLapsePortTypeClient client2 = new MelbourneWeatherTimeLapsePortTypeClient("MelbourneWeatherTimeLapseHttpSoap12Endpoint");
        private SOAPService service;
        private TimeLapse timeLapse;
        //private Monitor monitor;
        private ArrayList rainSub = new ArrayList();
        private ArrayList tempSub = new ArrayList();
        private ArrayList allDataSub = new ArrayList();
        private ArrayList monitors = new ArrayList();
        private ArrayList formMonitors = new ArrayList();

        //public string local;

        private Monitor monitor;
        private Rainfall rainfall;
        private Temperature temperature;
        private AllData allData;
        private TimeLapseData timelapse;
        private CfrmMonitors mon;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addSubjects();
            displayMonitors();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Locations();
        }


        private void Locations()
        {
            service = new SOAPService(client);
            string[] locations = (string[])service.getLocation();

            foreach(string location in locations)
            {
                cmbLocations.Items.Add(location);
            }
            cmbLocations.Text = cmbLocations.Items[0].ToString();
        }

        private void addSubjects()
        {
            mon = new CfrmMonitors();
            string local = cmbLocations.SelectedItem.ToString();
            bool isRain = false;
            bool isTemp = false;
            bool isAll = false;
            if(ckbRainfall.Checked && ckbTemperature.Checked)
            {
                foreach(AllData a in allDataSub)
                {
                    if (a.getLocation().Equals(local))
                    {
                        isAll = true;
                    }
                }
                isTemp = true;
                isRain = true;            
            }
            else if (ckbRainfall.Checked)
            {
                foreach (Rainfall r in rainSub)
                {
                    if (r.getLocation().Equals(local))
                    {
                        isRain = true;
                    }
                }
                isTemp = true;
                isAll = true;
            }
            else if(ckbTemperature.Checked)
            {
                foreach (Temperature t in tempSub)
                {
                    if (t.getLocation().Equals(local))
                    {
                        isRain = true;
                    }
                }
                isAll = true;
                isRain = true;
            }
            if(isAll == false)
            {
                allData = new AllData();
                monitor = new Monitor(local, allData);
                allData.setData(local, service.getRainfall(local), service.getTemperature(local));
                allDataSub.Add(allData);
                monitors.Add(monitor);
            }
            if(isRain == false)
            {
                rainfall = new Rainfall();
                monitor = new Monitor(local, rainfall);
                rainfall.setData(local, service.getTemperature(local));
                rainSub.Add(rainfall);
                monitors.Add(monitor);
            }
            if(isTemp == false)
            {
                temperature = new Temperature();
                monitor = new Monitor(local, temperature);
                temperature.setData(local, service.getTemperature(local));
                tempSub.Add(temperature);
                monitors.Add(monitor);
            }
            formMonitors.Add(mon);
        }

        private void updateSubjects()
        {
            foreach(Rainfall r in rainSub)
            {
                r.newData(service.getRainfall(r.getLocation()));
            }
            foreach(Temperature t in tempSub)
            {
                t.newData(service.getTemperature(t.getLocation()));
            }
            foreach(AllData a in allDataSub)
            {
                a.newData(service.getRainfall(a.getLocation()), service.getTemperature(a.getLocation()));
            }
        }
        private void displayMonitors()
        {
            for(int i = 0; i < formMonitors.Count; i++)
            {
                mon = (CfrmMonitors)formMonitors[i];
                monitor = (Monitor)monitors[i];
                if (!mon.Visible)
                {
                    mon.getLblLocation().Text = monitor.display().ToString();
                    mon.Show();
                }
            }            
        }
    }
}
