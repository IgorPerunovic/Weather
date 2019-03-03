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


	    private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        this.ForecastList.SelectedItem = null; // we don't want to mark selected item, for now tapping does nothing
	    }
    }
}