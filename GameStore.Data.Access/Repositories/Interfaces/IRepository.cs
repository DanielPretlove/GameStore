using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Data.Entities.Entities;

namespace GameStore.Data.Access.Repositories.Interfaces
{
    /// <summary>
    /// basic crud operations for customer, games and store
    /// you can add/edit/delete/getall and getId via the customer 
    /// you can add/edit/delete/getall and getId via the games 
    /// you can add/edit/delete/getall and getId via the store 
    /// </summary>
    public interface IRepository<T>
    {
        Task<T> GetDataByIdAsync(Guid id);
        Task<IList<T>> GetAllDataAsync();
        Task<T> CreateDataAsync(T data);
        Task UpdateDataAsync(T data);
        Task<T> DeleteDataAsync(Guid id);
    }
}
