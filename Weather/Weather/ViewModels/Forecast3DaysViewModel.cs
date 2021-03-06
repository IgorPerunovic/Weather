﻿using System.Threading.Tasks;
using Weather.Models;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class Forecast3DaysViewModel : BaseViewModel
    {
        #region ForecastBase Forecast
        ForecastBase forecast;
        public ForecastBase Forecast
        {
            get => forecast;
            set => SetProperty(ref forecast, value);
        }
        #endregion

        #region GetForecastCommand
        public Command Get3DaysForecastCommand { get; set; }

        private async Task Get3DaysForecast()
        {
            var location = await LocationService.GetCurrentLocation();
            this.Forecast = await this.DataService.GetForecastForDays(location, 3);
        }
        #endregion

        public Forecast3DaysViewModel()
        {
            Title = "Next 3 Days";
            Get3DaysForecastCommand = new Command(async () => await Get3DaysForecast());

        }
    }
}
