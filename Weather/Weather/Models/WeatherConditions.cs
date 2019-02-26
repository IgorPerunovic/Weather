using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Models
{
    public class WeatherConditions : WeatherConditionsBase
    {
        public new string Conditions => "Always sunny";
    }
}
