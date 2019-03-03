using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForecastListItemView : ContentView
	{
		public ForecastListItemView ()
		{
			InitializeComponent ();
		}
	}
}