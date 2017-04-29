using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hopeful
{
    interface WeatherService
    {
        string[] getLocation();
        string[] getRainfall(string location);
        string[] getTemperature(string location);
    }
}
