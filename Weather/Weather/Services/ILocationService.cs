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
