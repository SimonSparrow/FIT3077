using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Hopeful.MelborneWeatherService;

namespace Hopeful
{
    class GetData : ISubject
    {
        public ArrayList observers;
        public string[] rainfall;
        public string[] temperature;
        public string location;
        public GetData()
        {
            observers = new ArrayList();
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
                observer.update(location, rainfall, temperature);
            }
        }

        public void dataChanged()
        {
            NotifyObserver();
        }

        public void setData(string location, string[] rainfall, string[] temperature)
        {
            this.location = location;
            this.rainfall = rainfall;
            this.temperature = temperature;
        }

    }
}
