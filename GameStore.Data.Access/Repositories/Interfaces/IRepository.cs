using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Data.Entities.Entities;

namespace GameStore.Data.Access.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetDataByIdAsync(Guid id);
        Task<IList<T>> GetAllDataAsync();
        Task<T> CreateDataAsync(T data);
        Task UpdateDataAsync(T data);
        Task<T> DeleteDataAsync(Guid id);
    }
}
