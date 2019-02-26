using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Models
{
    public abstract class WeatherConditionsBase
    {
        public double Temperature { get; set; } // degrees
        public string Conditions { get; set; } // description
        public int Clouds { get; set; } // percent coverage
        public string ImgSource { get; set; } // the source for the icon representing the weather
        public string Wind { get; set; } // description of wind  
    }
}
