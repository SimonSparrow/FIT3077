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
                observer.update();
            }
        }

        public void dataChanged()
        {
            NotifyObserver();
        }

        public void setData(MelbourneWeather2PortTypeClient client, string location)
        {
            GetLocation local = new GetLocation(client, location);
            local.update();
        }
    }
}
