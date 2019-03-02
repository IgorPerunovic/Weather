using System;
using System.Collections.Generic;
using System.Text;
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
        public new string Wind => "Speed: "+WindConditions.Speed + " Deg: "+ WindConditions.Deg;
        public new string Conditions => WeatherReports[0]?.Description;
        public new double Temperature => main.Temp;
        public new double MinTemperature => main.MinTemp;
        public new double MaxTemperature => main.MaxTemp;

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
