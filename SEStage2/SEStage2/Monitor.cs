using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEStage2
{
    class Monitor : WeatherData, IObserver, Display
    {
        private string location;
        private object rainfall;
        private object temperature;
        private ISubject data1;
        private ISubject data2;
        public Monitor(string location, ISubject data1)
        {
            this.location = location;
            this.data1 = data1;
            data1.RegisterObserver(this);
        }
        public void updateRainfall(object rainfall)
        {
            this.rainfall = this.getData(rainfall);
        }

        public void updateTemperature(object temperature)
        {
            this.temperature = this.getData(temperature);
        }

        public void updateWeatherData(object rainfall, object temperature)
        {
            this.rainfall = rainfall;
            this.temperature = temperature;
        }

        public object display()
        {
            string msg = location + "\n";
            msg += "Rainfall: " + info((string[])rainfall) + "\n";
            msg += "Temperature: " + info((string[])temperature) + "\n";
            return msg;
        }

        private string info(string[] data)
        {
            if (!data[1].Equals(""))
            {
                return data[1];
            }
            else
                return "";
        }
    }
}
