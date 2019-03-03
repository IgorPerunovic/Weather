using System;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Weather.Models;

namespace Weather.Services
{
    public class LocationService : ILocationService
    {
        public async Task<Location> GetCurrentLocation()
        {
            Location result = new Location();
            if (IsLocationAvailable())
            {
                await CrossGeolocator.Current.GetPositionAsync(TimeSpan.FromSeconds(5)).ContinueWith(task =>
                {
                    if (task.IsCompleted)
                    {
                        var location = task.Result;
                        result = new Location(){Latitude = location.Latitude, Longitude = location.Longitude};
                    }
                });
                return result;
            }
            return null;
        }

        public bool IsLocationAvailable()
        {
            if (!CrossGeolocator.IsSupported)
                return false;
            return CrossGeolocator.Current.IsGeolocationAvailable;
        }
    }
}