using Weather.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Forecast3Days : ContentPage
	{
		public Forecast3Days ()
		{
			InitializeComponent ();
		}
	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        ((Forecast3DaysViewModel)this.BindingContext).Get3DaysForecastCommand.Execute(null);
	    }
    }
}