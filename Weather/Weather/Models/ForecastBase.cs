using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Models
{
    public abstract class ForecastBase
    {
        public List<WeatherConditionsBase> List { get; set; }

    }
}
