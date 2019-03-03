using System.Collections.Generic;
using System.Linq;
using Weather.Models;

namespace Weather.Services
{
    public static class CoversionHelper
    {
        public static WeatherConditionsBase GetWeatherConditions(string json)
        {
            return WeatherConditions.FromJson(json);
        }

        public static Forecast GetForecastForDays(string json, int days)
        {
           var fullForecast = Forecast.FromJson(json);
            var list = new List<WeatherConditions>();
            foreach (var element in fullForecast.List) // filtering the multiple forecasts per day (every few hours) into one per day
                // this could have been done better, but I frankly didn't have enough time to filter and compare all temperatures etc, and it's just a demo
                // at best, I could find the most often seen conditions for each day and find the min/max temperatures with a while loop
            //we're removing the duplicate dates and not adding beyond the required number of days (the API can return more than needed)
            {
                if (!list.Any(e => e.Date.Date.Equals(element.Date.Date)) && !(list.Count>=days))
                {
                    list.Add(element);
                } 
            }
            var forecast = fullForecast;
            forecast.List = list;
            return forecast;
        }
    }
}
