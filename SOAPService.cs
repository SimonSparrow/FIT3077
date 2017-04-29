using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hopeful.MelborneWeatherService;

namespace Hopeful 
{
    class SOAPService : WeatherService
    {
        private MelbourneWeather2PortTypeClient client;
        public SOAPService (MelbourneWeather2PortTypeClient client)
        {
            this.client = client;
        }

        public string[] getLocation()
        {
            getLocationsRequest locationsRequest = new getLocationsRequest();
            getLocationsResponse locationsResponse = new getLocationsResponse(client.getLocations());
            string[] locations = locationsResponse.@return;
            return locations;
        }

        public string[] getRainfall(string location)
        {
            getRainfallRequest rainfallRequest = new getRainfallRequest();
            rainfallRequest.location = location;
            getRainfallResponse rainfallResponse = new getRainfallResponse(client.getRainfall(location));
            string[] rainfallData = rainfallResponse.@return;
            return rainfallData;
        }

        public string[] getTemperature(string location)
        {
            getTemperatureRequest temperatureRequest = new getTemperatureRequest();
            temperatureRequest.location = location;
            getTemperatureResponse temperatureResponse = new getTemperatureResponse(client.getTemperature(location));
            string[] temperatureData = temperatureResponse.@return;
            return temperatureData;
        }
    }
}
