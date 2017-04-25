using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hopeful.MelborneWeatherService;

namespace Hopeful
{
    class GetLocation : IObserver, IDisplay
    {
        public MelbourneWeather2PortTypeClient client;
        public string rainfall;
        public string temperature;
        public string location;

        public GetLocation(MelbourneWeather2PortTypeClient client, string location)
        {
            this.client = client;
            this.location = location;
        }

        public GetLocation(MelbourneWeather2PortTypeClient client)
        {
            this.client = client;
        }
        public string[] Locations()
        {
            
            getLocationsRequest locationsRequest = new getLocationsRequest();
            getLocationsResponse locationsResponse = new getLocationsResponse(client.getLocations());
            string[] locations = locationsResponse.@return;
            return locations;
        }

        public void update()
        {
            rainfall = getRainfall();
            temperature = getTemperature();
        }

        public object Display()
        {
            return "Location: " + location + "\nRainfall: " + rainfall + " mm\nTemperature: " + temperature + "\n\n";
        }

        public string getRainfall()
        {
            getRainfallRequest rainfallRequest = new getRainfallRequest();
            rainfallRequest.location = location;
            getRainfallResponse rainfallResponse = new getRainfallResponse(client.getRainfall(location));
            string[] rainfallData = rainfallResponse.@return;
            return rainfallData[1];
        }

        public string getTemperature()
        {
            getTemperatureRequest temperatureRequest = new getTemperatureRequest();
            temperatureRequest.location = location;
            getTemperatureResponse temperatureResponse = new getTemperatureResponse(client.getTemperature(location));
            string[] temperatureData = temperatureResponse.@return;
            return temperatureData[1];
        }
    }
}
