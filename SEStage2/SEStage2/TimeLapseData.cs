using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEStage2
{
    class TimeLapseData : WeatherData, ISubject
    {
        private ArrayList observers;
        private ArrayList rainData;
        private ArrayList tempData;
        private ArrayList dateData;
        private object lapseData;
        private string location;
        public TimeLapseData()
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

        public ArrayList getObservers()
        {
            return observers;
        }

        public object getLapseData()
        {
            return lapseData;
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
                observer.updateTimeLapse(lapseData);
            }
            string[] time = getData(lapseData);
            DateTime date = DateTime.Parse(time[0].Substring(10));
            double temp = double.Parse(time[1].Replace('.', ','));
            double rain = double.Parse(time[2].Replace('.', ','));
            temp = temp - 273.15;
            rain = rain * 10.0;
            rainData.Add(rain);
            tempData.Add(temp);
            dateData.Add(date);
        }

        public void newData(object lapseData)
        {
            this.lapseData = lapseData;
            NotifyObserver();
        }

        public void setData(string location, object lapseData)
        {
            this.location = location;
            this.lapseData = lapseData;
            NotifyObserver();
        }
    }
}
