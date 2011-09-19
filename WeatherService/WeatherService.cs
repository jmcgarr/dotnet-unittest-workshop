using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherService
{
    public class WeatherService
    {
        private IWeatherDao weatherDao;

        public WeatherService (IWeatherDao dao)
        {
            weatherDao = dao;
        }

        public int CurrentTemp()
        {

            return weatherDao.GetCurrentTemperature();
        }

        public string convert(Temperature temp)
        {
            return weatherDao.ConvertToString(temp);
        }
    }
}
