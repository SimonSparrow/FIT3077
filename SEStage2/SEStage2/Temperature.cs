using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEStage2 
{
    class Temperature : WeatherData, ISubject
    {
        private ArrayList observers;
        private object temperature;
        private string location;
        public Temperature()
        {
            observers = new ArrayList();
        }

        public string getLocation()
        {
            return this.location;
        }

        public ArrayList getTemperature()
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
                observer.updateTemperature(temperature);
            }
        }

        public void newData(object temperature)
        {
            this.temperature = temperature;
            NotifyObserver();
        }

        public void setData(string location, object temperature)
        {
            this.location = location;
            this.temperature = temperature;
            NotifyObserver();
        }
    }
}
