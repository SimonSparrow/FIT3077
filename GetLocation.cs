using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hopeful.MelborneWeatherService;

namespace Hopeful
{
    class GetLocation : IObserver
    {
        public string[] rainfall;
        public string[] temperature;
        public string location;

        private ISubject data;
        public GetLocation(ISubject data)
        {
            this.data = data;
        }
        public void update(string location, string[] rainfall, string[] temperature)
        {
            this.location = location;
            this.rainfall = rainfall;
            this.temperature = temperature;
        }
    }
}
