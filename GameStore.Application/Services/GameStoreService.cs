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
	public class GameStoreService<T>
		where T : BaseEntity
	{ 
		private readonly IRepository<T> _modelCustomerRetrieveService;
		public GameStoreService(IRepository<T> modelCustomerRetrieveService)
		{
			_modelCustomerRetrieveService = modelCustomerRetrieveService;
		}

		public async Task<IList<T>> GetAllDataList()
		{
			return await _modelCustomerRetrieveService.GetAllDataAsync();
		}

		public async Task<T> GetDataById(Guid id)
		{
			return await _modelCustomerRetrieveService.GetDataByIdAsync(id);
		}

		public async Task<T> CreateNewData(T data)
		{
			return await _modelCustomerRetrieveService.CreateDataAsync(data);
		}

		public async Task UpdataData(T data)
		{
			await _modelCustomerRetrieveService.UpdateDataAsync(data);
		}

		public async Task<T> DeleteData(Guid id)
		{
			return await _modelCustomerRetrieveService.DeleteDataAsync(id);
		}
	}
}
