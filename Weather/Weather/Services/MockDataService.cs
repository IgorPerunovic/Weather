using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public class MockDataService : IDataService<Location>
    {
        // ideally, with a more complicated system, we'd mock various data, and test the results locally, 
        // without having to rely on API for actual data (we can put in whatever we want easily and quickly)
        // in this example, it wasn't really necessary, but the principle stands
        public async Task<WeatherConditionsBase> GetCurrentWeather(Location location)
        {
            var weather = new WeatherConditions();
            return await Task.FromResult(weather);
        }

        public async Task<ForecastBase> GetForecastForDays(Location location, int days)
        {
            var forecast = new Forecast();
            return await Task.FromResult(forecast);
        }
    }
}
