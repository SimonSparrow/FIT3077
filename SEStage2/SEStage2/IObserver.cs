using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEStage2
{
    interface IObserver
    {
        void updateRainfall(object rain);
        void updateTemperature(object temp);

        void updateWeatherData(object rain, object temp);
    }
}
