using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public interface IDataService<T>
    {
        Task<WeatherConditionsBase> GetCurrentWeather(T location);
        Task<ForecastBase> GetForecastForDays(T location, int days);
    }
}
