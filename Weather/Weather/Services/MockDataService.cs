using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public class MockDataService : IDataService<Location>
    {
        public async Task<WeatherConditionsBase> GetCurrentWeather(Location location)
        {
            var weather = new WeatherConditions();
            return await Task.FromResult(weather);
        }

        public Task<IEnumerable<WeatherConditionsBase>> GetForecastForDays(Location location, int days)
        {
            throw new NotImplementedException();
        }
    }
}
