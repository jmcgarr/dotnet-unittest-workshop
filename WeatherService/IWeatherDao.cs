using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherService
{
    public interface IWeatherDao
    {
        int GetCurrentTemperature();

        string ConvertToString(Temperature obj);


    }

    public class Temperature
    {
        public int temp { get; set; }
        public string scale { get; set; }
    }
}
