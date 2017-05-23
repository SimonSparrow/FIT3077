using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEStage2
{
    abstract class WeatherData
    {
        public string[] getData(object data)
        {
            string[] information = new string[2];
            if (data.GetType() == information.GetType())
            {
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
            return null;
        }
    }
}
