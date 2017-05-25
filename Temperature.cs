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
        private ArrayList tempData;
        private ArrayList dateData;
        private object temperature;
        private string location;
        public Temperature()
        {
            observers = new ArrayList();
            tempData = new ArrayList();
            dateData = new ArrayList();
        }

        public string getLocation()
        {
            return this.location;
        }

        public ArrayList getTemperatureObservers()
        {
            return observers;
        }
        public ArrayList getTempData()
        {
            return tempData;
        }
        public ArrayList getDateData()
        {
            return dateData;
        }

        public object getTemperature()
        {
            return temperature;
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
            double d = double.Parse(getData(temperature)[1].Replace('.', ','));
            tempData.Add(d);
            dateData.Add(DateTime.Now);
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
