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
using System.Diagnostics;

namespace SEStage2
{
    public partial class Form1 : Form
    {
        private MelbourneWeather2PortTypeClient client = new MelbourneWeather2PortTypeClient("MelbourneWeather2HttpSoap12Endpoint");
        private MelbourneWeatherTimeLapsePortTypeClient client2 = new MelbourneWeatherTimeLapsePortTypeClient("MelbourneWeatherTimeLapseHttpSoap12Endpoint");
        private SOAPService service;
        private TimeLapse timeLapse;
        private Stopwatch sw = new Stopwatch();
        private Stopwatch tldUpdate = new Stopwatch();

        //Subject ArrayLists
        private ArrayList rainSub = new ArrayList();
        private ArrayList tempSub = new ArrayList();
        private ArrayList allDataSub = new ArrayList();
        private ArrayList timeSub = new ArrayList();

        //Monitor ArrayLists
        private ArrayList monitors = new ArrayList();
        private ArrayList formMonitors = new ArrayList();

        //Objects
        private Monitor monitor;
        private Rainfall rainfall;
        private Temperature temperature;
        private AllData allData;
        private TimeLapseData timelapseData;
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
            timeLapse = new TimeLapse(client2);
            tmrUpdate.Start();
        }
        private void Locations()
        {
            service = new SOAPService(client);
            string[] locations = (string[])service.getLocation();

            foreach (string location in locations)
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

            if ((ckbRainfall.Checked && ckbTemperature.Checked) || (!ckbRainfall.Checked && !ckbTemperature.Checked))
            {
                for (int i = allDataSub.Count - 1; i >= 0; i--)
                {
                    if (allDataSub[i].GetType() == typeof(AllData))
                    {
                        allData = (AllData)allDataSub[i];
                        if (allData.getLocation().Equals(local))
                        {
                            if (allData.getLocation().Equals(local))
                            {
                                isAll = true;
                                monitor = new Monitor(local, allData);
                                allData.NotifyObserver();
                                monitors.Add(monitor);
                            }
                        }
                    }

                }
                isTemp = true;
                isRain = true;
            }
            else if (ckbRainfall.Checked)
            {
                for (int i = rainSub.Count - 1; i >= 0; i--)
                {
                    if (rainSub[i].GetType() == typeof(Rainfall))
                    {
                        rainfall = (Rainfall)rainSub[i];
                        if (rainfall.getLocation().Equals(local))
                        {
                            isRain = true;
                            monitor = new Monitor(local, rainfall);
                            rainfall.NotifyObserver();
                            monitors.Add(monitor);
                        }
                    }
                }
                isTemp = true;
                isAll = true;
            }
            else if (ckbTemperature.Checked)
            {
                for (int i = tempSub.Count - 1; i >= 0; i--)
                {
                    if (tempSub[i].GetType() == typeof(Temperature))
                    {
                        temperature = (Temperature)tempSub[i];
                        if (temperature.getLocation().Equals(local))
                        {
                            isRain = true;
                            monitor = new Monitor(local, temperature);
                            temperature.NotifyObserver();
                            monitors.Add(monitor);
                        }
                    }
                }
                isAll = true;
                isRain = true;
            }
            if (isAll == false)
            {
                allData = new AllData();
                monitor = new Monitor(local, allData);
                allData.setData(local, service.getRainfall(local), service.getTemperature(local));
                allDataSub.Add(allData);
                monitors.Add(monitor);
            }
            if (isRain == false)
            {
                rainfall = new Rainfall();
                monitor = new Monitor(local, rainfall);
                rainfall.setData(local, service.getRainfall(local));
                rainSub.Add(rainfall);
                monitors.Add(monitor);
            }
            if (isTemp == false)
            {
                temperature = new Temperature();
                monitor = new Monitor(local, temperature);
                temperature.setData(local, service.getTemperature(local));
                tempSub.Add(temperature);
                monitors.Add(monitor);
            }
            bool isTime = false;
            for (int i = timeSub.Count - 1; i >= 0; i--)
            {
                timelapseData = (TimeLapseData)timeSub[i];
                if (timelapseData.getLocation().Equals(cmbLocations.SelectedItem.ToString()))
                {
                    isTime = true;
                    monitor = new Monitor(local, timelapseData);
                    timelapseData.NotifyObserver();
                }
            }
            if(isTime == false)
            {
                timelapseData = new TimeLapseData();
                monitor = new Monitor(local, timelapseData);
                timelapseData.setData(local, timeLapse.getWeatherData(local));
                timeSub.Add(timelapseData);
            }
            formMonitors.Add(mon);
            //allMonitors();
        }
        private void updateSubjects()
        {
            foreach (object r in rainSub)
            {
                if (r.GetType() == typeof(Rainfall))
                {
                    rainfall = (Rainfall)r;
                    rainfall.newData(service.getRainfall(rainfall.getLocation()));
                }
            }
            foreach (object t in tempSub)
            {
                if (t.GetType() == typeof(Temperature))
                {
                    temperature = (Temperature)t;
                    temperature.newData(service.getTemperature(temperature.getLocation()));
                }
            }
            foreach (object a in allDataSub)
            {
                if (a.GetType() == typeof(AllData))
                {
                    allData = (AllData)a;
                    allData.newData(service.getRainfall(allData.getLocation()), service.getTemperature(allData.getLocation()));
                }
            }
            displayMonitors();
        }
        public void displayMonitors()
        {
            int count = 0;
            foreach (AllData a in allDataSub)
            {
                foreach (IObserver o in a.getWeather())
                {
                    allChart((CfrmMonitors)formMonitors[count], (Monitor)o, a);
                    count++;
                }
            }
            foreach(Rainfall r in rainSub)
            {
                foreach (IObserver o in r.getRainfallObservers())
                {
                    rainfallChart((CfrmMonitors)formMonitors[count], (Monitor)o, r);
                    count++;
                }
            }
            foreach(Temperature t in tempSub)
            {
                foreach (IObserver o in t.getTemperatureObservers())
                {
                    temperatureChart((CfrmMonitors)formMonitors[count], (Monitor)o, t);
                    count++;
                }
            }
            count = 0;
            foreach(TimeLapseData tld in timeSub)
            {
                foreach(IObserver o in tld.getObservers())
                {
                    displayTimeLapse((CfrmMonitors)formMonitors[count], (Monitor)o, tld);
                }
            }


            

        }                 
        private void rainfallChart(CfrmMonitors chart, Monitor m, Rainfall r)
        {
            chart.getLblLocation().Text = m.display().ToString();
            chart.getChart().Series[1].Points.DataBindXY(r.getDateData(), r.getRainData());
            chart.getChart().Series[0].IsVisibleInLegend = false;
            chart.Show();
        }
        private void temperatureChart(CfrmMonitors chart, Monitor m, Temperature t)
        {
            chart.getLblLocation().Text = m.display().ToString();
            chart.getChart().Series[0].Points.DataBindXY(t.getDateData(), t.getTempData());
            chart.getChart().Series[1].IsVisibleInLegend = false;
            chart.Show();
        }
        private void allChart(CfrmMonitors chart, Monitor m, AllData a)
        {
            chart.getLblLocation().Text = m.display().ToString();
            chart.getChart().Series[0].Points.DataBindXY(a.getDateData(), a.getTempData());
            chart.getChart().Series[1].Points.DataBindXY(a.getDateData(), a.getRainData());
            chart.Show();
        }
        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (formMonitors.Count > 0)
            {
                sw.Start();
                tldUpdate.Start();
                if (sw.Elapsed.Minutes == 5)
                {
                    updateSubjects();
                    sw.Restart();                    
                }
                if (tldUpdate.Elapsed.Seconds == 20)
                {
                    updateLapseData();
                    tldUpdate.Restart();
                }
            }
            else
            {
                sw.Reset();
            }

            lblTime.Text = sw.Elapsed.Minutes.ToString() + ":" + sw.Elapsed.Seconds.ToString("00");
        }
        private void removeMonitor(CfrmMonitors m)
        {
            CfrmMonitors cm;
            int index;
            for(int i = formMonitors.Count - 1; i >= 0; i--)
            {
                cm = (CfrmMonitors)formMonitors[i];
                if (cm.Equals(m))
                {
                    index = formMonitors.IndexOf(cm);
                    formMonitors.Remove(cm);
                    try
                    {
                        allDataSub.Remove(cm);
                        for (int k = allDataSub.Count - 1; k >= 0; k--)
                        {
                            if (allDataSub[i].GetType() == typeof(AllData))
                            {
                                allData = (AllData)allDataSub[i];
                                allData.RemoveObserver((IObserver)monitors[index]);
                            }
                        }
                        monitors.RemoveAt(index);
                    }

                    catch(System.Exception e)
                    {
                        MessageBox.Show("Could not find observer in " + e.ToString());
                    }
                    try
                    {
                        rainSub.Remove(cm);
                        for (int k = rainSub.Count - 1; k >= 0; k--)
                        {
                            if (rainSub[i].GetType() == typeof(Rainfall))
                            {
                                rainfall = (Rainfall)rainSub[i];
                                rainfall.RemoveObserver((IObserver)monitors[index]);
                            }
                        }
                        monitors.RemoveAt(index);
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show("Could not find observer in " + e.ToString());
                    }
                    try
                    {
                        tempSub.Remove(cm);
                        for (int k = tempSub.Count - 1; k >= 0; k--)
                        {
                            if (tempSub[i].GetType() == typeof(Temperature))
                            {
                                temperature = (Temperature)tempSub[i];
                                temperature.RemoveObserver((IObserver)monitors[index]);
                            }
                        }
                        monitors.RemoveAt(index);
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show("Could not find observer in " + e.ToString());
                    }
                }
            }
        }
        private void weatherData()
        {
            timelapseData.getObservers().Clear();
            foreach (Monitor m in monitors)
            {
                timelapseData.getObservers().Add((IObserver)m);
            }
            timelapseData.newData(timeLapse.getWeatherData(cmbLocations.SelectedItem.ToString()));
        }
        private void displayTimeLapse(CfrmMonitors chart, Monitor m, TimeLapseData tld)
        {
            string msg = "\nRainfall: " + tld.getRainData()[tld.getRainData().Count - 1].ToString() + "mm\nTemperature: " + tld.getTempData()[tld.getTempData().Count - 1].ToString() + "°C";
            chart.getLblLapse().Text = m.display().ToString() + msg;
            chart.getChart().Series[3].Points.DataBindXY(tld.getDateData(), tld.getRainData());
            chart.getChart().Series[2].Points.DataBindXY(tld.getDateData(), tld.getTempData());
        }
        private void updateLapseData()
        {
            foreach(TimeLapseData tld in timeSub)
            {
                tld.newData(timeLapse.getWeatherData(tld.getLocation()));
            }
            displayMonitors();
        }
    }
}
