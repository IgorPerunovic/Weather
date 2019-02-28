using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Weather.Models
{
    public class WeatherType
    {
        //[JsonProperty("description")]
        public string Description { get; set; }

        //[JsonProperty("icon")]
        public string Icon { get; set; }

    }
}
