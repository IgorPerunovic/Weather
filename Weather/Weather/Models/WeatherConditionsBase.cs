using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Weather.Models
{
    public abstract class WeatherConditionsBase
    {
        public double Temperature { get; set; } // degrees
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }

        public string Conditions { get; set; } // description
        public string WeatherCode { get; set; } // the source for the icon representing the weather
        public string Wind { get; set; } // description of wind conditions 
        public string Humidity { get; set; } 
        public string Pressure { get; set; } // in units of mbar
        public DateTime Date { get; set; } // date this applies to
    }
}
