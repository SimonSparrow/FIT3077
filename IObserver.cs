using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hopeful.MelborneWeatherService;

namespace Hopeful
{
    interface IObserver
    {
        void update();
    }
}
