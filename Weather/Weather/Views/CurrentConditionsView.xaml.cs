using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentConditionsView : ContentView
    {
        public CurrentConditionsView()
        {
            InitializeComponent();
        }



        public static BindableProperty WeatherConditionsProperty = BindableProperty.Create(
            propertyName: "WeatherConditions",
            returnType: typeof(WeatherConditionsBase),
            declaringType: typeof(CurrentConditionsView),
            defaultValue: null,
            defaultBindingMode: BindingMode.Default,
            propertyChanged: (b, o, n) =>
            {
                ((CurrentConditionsView) b).BindingContext = (WeatherConditionsBase) n;
                Console.WriteLine("change!");
                Console.WriteLine("new value:" + ((WeatherConditionsBase)n).Conditions);
            });



    }
}