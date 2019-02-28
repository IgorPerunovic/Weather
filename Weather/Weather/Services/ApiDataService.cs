using System;
using System.Collections.Generic;
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

        //api.openweathermap.org/data/2.5/weather? zip = 94040, us
        public async Task<WeatherConditionsBase> GetCurrentWeather(Location location)
        {
            HttpClient httpClient = new HttpClient();
            var uri = BASE + CURRENT + "id=524901&APPID=" + APP_KEY;
            try
            {
                var result = await httpClient.GetStringAsync(uri);
                return await Task.FromResult(CoversionHelper.GetWeatherConditions(result));
            }
            catch (Exception e)
            {
                System.Console.Write(e.Message);
            }

            return null;

        }

        public async Task<IEnumerable<WeatherConditionsBase>> GetForecastForDays(Location location, int days)
        {
            HttpClient httpClient = new HttpClient();
            var uri = BASE + FORECAST + "id=524901&APPID=" + APP_KEY;
            try
            {
                var result = await httpClient.GetStringAsync(uri);
                return await Task.FromResult(Services.CoversionHelper.GetForecastForDays(result, days));
            }
            catch (Exception e)
            {
                System.Console.Write(e.Message);
            }

            return null;
        }
    }
}
