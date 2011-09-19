using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherService
{
    public class TemperatureUtil
    {
        public bool isFreezing(int temperature)
        {
            return temperature < 32;
        }

        public int ConvertToCelsius(int temperature)
        {
            if (temperature < (-459.67))
                throw new ArgumentException("cannot convert absolute zero");
            return (temperature - 32)*5/9;
        }
    }
}
