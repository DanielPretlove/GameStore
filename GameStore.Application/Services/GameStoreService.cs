using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Application.Services;
using GameStore.Data.Access.Repositories.Interfaces;
using GameStore.Data.Entities.Entities;

namespace GameStore.Application.Services
{
	public class GameStoreService<TEntity>
		where TEntity : BaseEntity
	{ 

		// create a game count
		// create a purchase 
		private readonly IRepository<TEntity> _modelCustomerRetrieveService;
		public GameStoreService(IRepository<TEntity> modelCustomerRetrieveService)
		{
			_modelCustomerRetrieveService = modelCustomerRetrieveService;
		}

		public async Task<IList<TEntity>> GetAllDataList()
		{
			return await _modelCustomerRetrieveService.GetAllDataAsync();
		}

		public async Task<TEntity> GetDataById(Guid id)
		{
			return await _modelCustomerRetrieveService.GetDataByIdAsync(id);
		}

		public async Task<TEntity> CreateNewData(TEntity data)
		{
			return await _modelCustomerRetrieveService.CreateDataAsync(data);
		}

		public async Task UpdataData(TEntity data)
		{
			await _modelCustomerRetrieveService.UpdateDataAsync(data);
		}

		public async Task<TEntity> DeleteData(Guid id)
		{
			return await _modelCustomerRetrieveService.DeleteDataAsync(id);
		}
	}
}
