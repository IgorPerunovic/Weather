using Weather.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Forecast5Days : ContentPage
	{
		public Forecast5Days ()
		{
			InitializeComponent ();
		}
	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        ((Forecast5DaysViewModel)this.BindingContext).Get5DaysForecastCommand.Execute(null);
	    }
    }
}