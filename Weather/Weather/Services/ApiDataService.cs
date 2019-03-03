using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public class ApiDataService : IDataService<Location>
    {
        private const string APP_KEY = "744b7e1fc3a4e4f57674263944e2aee9";
        private const string BASE = "http://api.openweathermap.org/data/2.5/";
        private const string FORECAST = "forecast?";
        private const string CURRENT = "weather?";

        private const string UNIT_FORMAT = "&units=metric"; // ideally, this would be part of some preferences provider, 
                                                           //but here it's hardcoded, didn't have time to make prefs

        public async Task<WeatherConditionsBase> GetCurrentWeather(Location location)
        {
            if (location == null)
            {
                return null;
            }

            string locationString = (string.IsNullOrEmpty(location.Id)) 
                ? ("lat=" + location.Latitude + "&lon=" + location.Longitude)
                : "id="+location.Id;

            var requestUri = string.Format(
                CultureInfo.InvariantCulture,
                "{0}{1}{2}{3}&APPID={4}",
                BASE, CURRENT, locationString, UNIT_FORMAT, APP_KEY);

            HttpClient httpClient = new HttpClient();
            try
            {
                var result = await httpClient.GetStringAsync(requestUri);
                return await Task.FromResult(CoversionHelper.GetWeatherConditions(result));
            }
            catch (Exception e)
            {
                ErrorHandler.HandleGenericAPIError(e);
            }

            return null;

        }

        public async Task<ForecastBase> GetForecastForDays(Location location, int days)
        {
            if (location == null)
            {
                return null;
            }

            string locationString = (string.IsNullOrEmpty(location.Id))
                ? ("lat=" + location.Latitude + "&lon=" + location.Longitude)
                : "id=" + location.Id;
            var requestUri = string.Format(
                CultureInfo.InvariantCulture,
                "{0}{1}{2}{3}&APPID={4}",
                BASE, FORECAST, locationString, UNIT_FORMAT, APP_KEY);
            HttpClient httpClient = new HttpClient();
            try
            {
                var result = await httpClient.GetStringAsync(requestUri);
                var forecast = await Task.FromResult(Services.CoversionHelper.GetForecastForDays(result, days));
                return forecast;
            }
            catch (Exception e)
            {
                ErrorHandler.HandleGenericAPIError(e);
            }

            return null;
        }
    }
}
