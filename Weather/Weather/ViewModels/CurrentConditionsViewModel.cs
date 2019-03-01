using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using Weather.Services;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class CurrentConditionsViewModel : BaseViewModel
    {
        #region WeatherConditions
        WeatherConditionsBase conditions;
        public WeatherConditionsBase Conditions
        {
            get => conditions;
            set => SetProperty(ref conditions, value);
        }
        #endregion



        public Command GetCurrentConditionsCommand { get; set; }
        public CurrentConditionsViewModel()
        {
            Title = "Current weather";
            GetCurrentConditionsCommand = new Command(async () => await GetCurrentConditions());
        }

        private async Task GetCurrentConditions()
        {
            var location = await LocationService.GetCurrentLocation();
            this.Conditions = await this.DataService.GetCurrentWeather(location);
        }
    }
}
