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
        private object temperature;
        private object rainfall;
        private string location;
        public AllData()
        {
            observers = new ArrayList();
        }

        public string getLocation()
        {
            return this.location;
        }

        public ArrayList getWeather()
        {
            return observers;
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

