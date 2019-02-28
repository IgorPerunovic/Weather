using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Weather.Models
{
    public class Forecast : ForecastBase
    {
        public new List<WeatherConditions> List { get; set; }


        public static Forecast FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Forecast>(json, Settings());
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
