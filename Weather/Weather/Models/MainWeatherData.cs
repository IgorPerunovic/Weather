
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Weather.Models
{
    class MainWeatherData
    {
        public double Temp { get; set; }
        [JsonProperty("temp_min")]
        public double MinTemp { get; set; }
        [JsonProperty("temp_max")]
        public double MaxTemp { get; set; }
        public int Humidity { get; set; }
        public double Pressure { get; set; }
    }
}
