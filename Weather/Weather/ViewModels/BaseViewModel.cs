﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using Weather.Models;
using Weather.Services;

namespace Weather.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        // this dependency isn't really IOC and DI, but it was just the fastest way to implement it
        public IDataService<Location> DataService => DependencyService.Get<IDataService<Location>>() ?? new ApiDataService();

        public ILocationService LocationService => DependencyService.Get<ILocationService>() ?? new LocationService();

        #region string Title
        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        #endregion

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
