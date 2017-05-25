using System;
using System.Collections;
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
        private object timeLapse;
        
        private ISubject data1;
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

        public void updateTimeLapse(object timeLapse)
        {
            this.timeLapse = timeLapse;
        }

        public object display()
        {
            string msg;
            string[] rain = (string[])rainfall;
            string[] temp = (string[])temperature;
            if (rainfall != null && temperature != null)
            {
                msg = location + "\nRainfall: " + rain[1] + "mm\nTemperature: " + temp[1] + "°C";
                return msg;
            }
            if(rainfall != null)
            {
                msg = location + "\nRainfall: " + rain[1] + "mm";
                return msg;
            }
            if(temperature != null)
            {
                msg = location + "\nTemperature: " + temp[1] + "°C";
                return msg;
            }
            else
            {
                msg = location;
                return msg;
            }
        }
    }
}
