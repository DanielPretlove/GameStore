using GameStore.Data.Access.Repositories;
using GameStore.Data.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Web.API.Controllers
{
	public class GameStoreController<T> : BaseApiController
		where T : BaseEntity
	{
		private readonly Repository<T> _repository; 
		public GameStoreController(Repository<T> repository) 
		{
			_repository = repository;
		}


		[HttpGet("{Customer}/{id:Guid}")]
		public async Task<ActionResult<T>> GetDataById(Guid id)
		{
			return await _repository.GetDataByIdAsync(id);
		}
	}
}
