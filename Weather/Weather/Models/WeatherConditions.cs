using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Models
{
    public class WeatherConditions : WeatherConditionsBase
    {

        public WeatherConditions()
        {
            this.Conditions = "not so sunny after all";
        }
        //public new string Conditions => "Always sunny";
    }
}
