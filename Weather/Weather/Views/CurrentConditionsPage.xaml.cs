using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CurrentConditionsPage : ContentPage
	{
	    private CurrentConditionsViewModel viewModel;
		public CurrentConditionsPage ()
		{
			InitializeComponent ();
            viewModel = new CurrentConditionsViewModel();
		    this.BindingContext = viewModel;
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();

	        viewModel.GetCurrentConditionsCommand.Execute(null);
	    }
    }
}