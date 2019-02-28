using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Weather.Models
{
    public abstract class WeatherConditionsBase
    {
        public double Temperature { get; set; } // degrees
        public string Conditions { get; set; } // description
        public string ImgSource { get; set; } // the source for the icon representing the weather
        public string Wind { get; set; } // description of wind conditions 
        public string Humidity { get; set; } 
        public DateTime Date { get; set; } // date this applies to
    }
}
