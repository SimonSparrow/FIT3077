using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEStage2.MelborneWeatherService;

namespace SEStage2
{
    class SOAPService : Service
    {
        private MelbourneWeather2PortTypeClient client;

        public SOAPService(MelbourneWeather2PortTypeClient client)
        {
            this.client = client;
        }

        public override object getLocation()
        {
            getLocationsRequest locationsRequest = new getLocationsRequest();
            getLocationsResponse locationsResponse = new getLocationsResponse(client.getLocations());
            return locationsResponse.@return; 
        }

        public object getRainfall(string location)
        {
            getRainfallRequest rainfallRequest = new getRainfallRequest();
            rainfallRequest.location = location;
            getRainfallResponse rainfallResponse = new getRainfallResponse(client.getRainfall(location));
            return rainfallResponse.@return;
        }

        public object getTemperature(string location)
        {
            getTemperatureRequest temperatureRequest = new getTemperatureRequest();
            temperatureRequest.location = location;
            getTemperatureResponse temperatureResponse = new getTemperatureResponse(client.getTemperature(location));
            return temperatureResponse.@return;
        }
    }
}
