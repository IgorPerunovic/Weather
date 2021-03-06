﻿using Weather.ViewModels;
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
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        ((CurrentConditionsViewModel)this.BindingContext).GetCurrentConditionsCommand.Execute(null);
	    }
    }
}