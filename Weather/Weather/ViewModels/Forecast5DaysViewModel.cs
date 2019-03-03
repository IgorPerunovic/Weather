using System.Threading.Tasks;
using Weather.Models;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class Forecast5DaysViewModel : BaseViewModel
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
        public Command Get5DaysForecastCommand { get; set; }
        private async Task Get5DaysForecast()
        {
            var location = await LocationService.GetCurrentLocation();
            this.Forecast = await this.DataService.GetForecastForDays(location, 5);
        }
        #endregion

        public Forecast5DaysViewModel()
        {
            Title = "Next 5 Days";
            Get5DaysForecastCommand = new Command(async () => await Get5DaysForecast());
        }
    }
}
