using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEStage2
{
    class Rainfall : WeatherData, ISubject
    {

        private ArrayList observers;
        private object rainfall;
        private string location;
        public Rainfall()
        {
            observers = new ArrayList();
        }

        public string getLocation()
        {
            return location;
        }

        public ArrayList getRainfall()
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
                observer.updateRainfall(rainfall);
            }
        }

        public void newData(object rainfall)
        {
            this.rainfall = rainfall;
            NotifyObserver();
        }
        public void setData(string location, object rainfall)
        {
            this.location = location;
            this.rainfall = rainfall;
            NotifyObserver();
        }
    }
}
