using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using Weather.Services;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class Forecast3DaysViewModel : BaseViewModel
    {
        ForecastBase forecast;
        public ForecastBase Forecast
        {
            get => forecast;
            set => SetProperty(ref forecast, value);
        }


        public Command Get3DaysForecastCommand { get; set; }
        public Forecast3DaysViewModel()
        {
            Title = "Current weather";
            Get3DaysForecastCommand = new Command(async () => await Get3DaysForecast());

        }

        private async Task Get3DaysForecast()
        {
            var location = await LocationService.GetCurrentLocation();
            //this.Conditions = await this.DataService.GetCurrentWeather(location)
            this.Forecast = await this.DataService.GetForecastForDays(location, 3);
            Console.WriteLine("forecast :" + forecast);
        }
    }
}
