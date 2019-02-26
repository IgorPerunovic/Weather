using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Services
{
    public interface IDataService<T>
    {
        Task<bool> AddItemAsync(T location);

    }
}
