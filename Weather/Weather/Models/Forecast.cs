using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Weather.Models
{
    public class Forecast
    {
        public List<WeatherConditionsBase> List { get; set; }


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
