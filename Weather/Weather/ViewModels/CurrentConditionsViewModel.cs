using System.Threading.Tasks;
using Weather.Models;
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

        #region GetCurrentConditionsCommand
        public Command GetCurrentConditionsCommand { get; set; }
        private async Task GetCurrentConditions()
        {
            var location = await LocationService.GetCurrentLocation();
            this.Conditions = await this.DataService.GetCurrentWeather(location);
        }
        #endregion

        public CurrentConditionsViewModel()
        {
            Title = "Current weather";
            GetCurrentConditionsCommand = new Command(async () => await GetCurrentConditions());
        }


    }
}
