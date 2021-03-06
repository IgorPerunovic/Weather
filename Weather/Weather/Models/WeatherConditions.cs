﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Weather.Models
{
    public class WeatherConditions : WeatherConditionsBase
    {
        [JsonProperty("main")]
        private MainWeatherData main { get; set; }

        [JsonProperty("wind")]
        private WindConditions WindConditions { get; set; }

        [JsonProperty("weather")]
        private List<WeatherType> WeatherReports{ get; set; }

        [JsonProperty("dt_txt")]
        public new DateTime Date { get; set; }

        public new string WeatherCode => WeatherReports[0]?.Icon;
        public new string Wind => WindConditions.Direction + ", " + WindConditions.Speed + "KPH"; //this could have been formatted more nicely, but this does the job
        public new string Conditions => WeatherReports[0]?.Description.ToUpper();
        public new int Temperature => (int)Math.Round(main.Temp);
        public new int MinTemperature => (int)Math.Round(main.MinTemp);
        public new int MaxTemperature => (int)Math.Round(main.MaxTemp);

        public new int Humidity => main.Humidity;
        public new string Pressure => main.Pressure.ToString();

      
        public static WeatherConditions FromJson(string json)
        {
            return JsonConvert.DeserializeObject<WeatherConditions>(json, Settings()); 
        }

        private static JsonSerializerSettings Settings()
        {
            return new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
}
