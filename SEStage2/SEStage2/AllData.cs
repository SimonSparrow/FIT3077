using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEStage2
{
    class AllData : WeatherData, ISubject
    {
        private ArrayList observers;
        private ArrayList rainData;
        private ArrayList tempData;
        private ArrayList dateData;
        private object temperature;
        private object rainfall;
        private string location;
        public AllData()
        {
            observers = new ArrayList();
            rainData = new ArrayList();
            tempData = new ArrayList();
            dateData = new ArrayList();

        }

        public string getLocation()
        {
            return this.location;
        }

        public ArrayList getWeather()
        {
            return observers;
        }

        public object getRain()
        {
            return rainfall;
        }

        public object getTemp()
        {
            return temperature;
        }
        public ArrayList getTempData()
        {
            return tempData;
        }

        public ArrayList getRainData()
        {
            return rainData;
        }
        public ArrayList getDateData()
        {
            return dateData;
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.updateWeatherData(rainfall, temperature);
            }
            double d = double.Parse(getData(rainfall)[1].Replace('.', ','));
            rainData.Add(d);
            d = double.Parse(getData(temperature)[1].Replace('.', ','));
            tempData.Add(d);
            dateData.Add(DateTime.Now);
        }

        public void newData(object rainfall, object temperature)
        {
            this.rainfall = rainfall;
            this.temperature = temperature;
            NotifyObserver();
        }

        public void setData(string location, object rainfall, object temperature)
        {
            this.location = location;
            this.rainfall = rainfall;
            this.temperature = temperature;
            NotifyObserver();
        }
    }
}

