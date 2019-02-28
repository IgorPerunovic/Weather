using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class CurrentConditionsViewModel : BaseViewModel
    {
        WeatherConditionsBase conditions;
        public WeatherConditionsBase Conditions
        {
            get => conditions;
            set => SetProperty(ref conditions, value);
        }


        public Command GetCurrentConditionsCommand { get; set; }
        public CurrentConditionsViewModel()
        {
            Title = "Current weather";
            GetCurrentConditionsCommand = new Command(async () => await GetCurrentConditions());

        }

        private async Task GetCurrentConditions()
        {
            this.Conditions = await this.DataService.GetCurrentWeather(null);
            
            //// ----------------------------- testing:
            var x = await this.DataService.GetForecastForDays(null, 19);

            System.Console.WriteLine("x is " + x);
        }
    }
}
