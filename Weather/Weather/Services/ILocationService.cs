using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.Models;

namespace Weather.Services
{
    public interface ILocationService
    {
        Task<Location> GetCurrentLocation();

        bool IsLocationAvailable();

    }
}
