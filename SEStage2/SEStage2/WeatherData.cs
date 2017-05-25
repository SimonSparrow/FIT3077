using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEStage2.MelborneTimeLapse;

namespace SEStage2
{
    abstract class WeatherData
    {
        private MelbourneWeatherTimeLapsePortTypeClient client = new MelbourneWeatherTimeLapsePortTypeClient("MelbourneWeatherTimeLapseHttpSoap12Endpoint");

        public object TimeLapseData(string location)
        {
            TimeLapse time = new TimeLapse(client);
            return time.getWeatherData(location);
        }
        public string[] getData(object data)
        {
            string[] information;
            try
            {
                information = (string[])data;
                return information;
            }
            catch
            {
                return null;
            }

        }
    }
}
