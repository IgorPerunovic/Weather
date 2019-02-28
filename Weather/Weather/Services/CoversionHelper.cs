using System;
using System.Collections.Generic;
using System.Text;
using Weather.Models;

namespace Weather.Services
{
    public static class CoversionHelper
    {
        public static WeatherConditionsBase GetWeatherConditions(string json)
        {
            return WeatherConditions.FromJson(json);
        }

        public static List<WeatherConditionsBase> GetForecastForDays(string json, int days)
        {
            return new List<WeatherConditionsBase>();
        }
    }
}
