using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEStage2.MelborneTimeLapse;

namespace SEStage2
{
    class TimeLapse : Service
    {
        private MelbourneWeatherTimeLapsePortTypeClient client;

        public TimeLapse(MelbourneWeatherTimeLapsePortTypeClient client)
        {
            this.client = client;
        }
        public override object getLocation()
        {
            getLocationsRequest locationsRequest = new getLocationsRequest();
            getLocationsResponse locationsResponse = new getLocationsResponse(client.getLocations());
            return locationsResponse.@return;
        }

        public object getWeatherData(string location)
        {
            getWeatherRequest weatherDataRequest = new getWeatherRequest();
            weatherDataRequest.location = location;
            getWeatherResponse weatherDataReponse = new getWeatherResponse(client.getWeather(location));
            return weatherDataReponse.@return;
        }
    }
}
