using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public interface IDataService<T>
    {
        Task<WeatherConditionsBase> GetCurrentWeather(T location);
        Task<IEnumerable<WeatherConditionsBase>> GetForecastForDays(T location, int days);
    }
}
