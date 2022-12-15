using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Data.Access.Repositories.Interfaces;
using GameStore.Data.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data.Access.Repositories
{

    public class Repository<T> : IRepository<T>
		where T : BaseEntity
    {
        private readonly GameStoreDataContext _context;
        public Repository(GameStoreDataContext context)
        {
            _context = context;
        }

		public async Task<T> CreateDataAsync(T data)
		{
			var result = await _context.AddAsync(data);
			await _context.SaveChangesAsync();
			return result.Entity;
		}

		public async Task<T> DeleteDataAsync(Guid id)
		{
			var result = await _context.Set<T>().FindAsync(id);
			_context.Set<T>().Remove(result);
			await _context.SaveChangesAsync();
			return result;
		}

		public async Task<IList<T>> GetAllDataAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task<T> GetDataByIdAsync(Guid id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task UpdateDataAsync(T data)
		{
			_context.Set<T>().Entry(data).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}
	}
}