using System;
using System.Collections.Generic;
using System.Text;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace Weather.ViewModels
{
    // This is a neat trick that helps with XAML accessing properties from the ViewModels and using  IDE autocomplete options
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
        }

        public CurrentConditionsViewModel CurrentConditions => ViewModel<CurrentConditionsViewModel>.Get();
        public Forecast3DaysViewModel Forecast3Days => ViewModel<Forecast3DaysViewModel>.Get();
        public Forecast5DaysViewModel Forecast5Days => ViewModel<Forecast5DaysViewModel>.Get();

        public static void Cleanup()
        {
        }

    }

    public class ViewModel<T> where T : BaseViewModel
    {
        public static T Get()
        {
            if (!SimpleIoc.Default.IsRegistered<T>())
            {
                SimpleIoc.Default.Register<T>();
            }
            return ServiceLocator.Current.GetInstance<T>();
        }
    }














}
