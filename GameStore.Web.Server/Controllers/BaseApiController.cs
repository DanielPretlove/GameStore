using AutoMapper;
using GameStore.Application.Services;
using GameStore.Common.Helpers;
using GameStore.Data.Entities.Entities;
using GameStore.Web.Shared.Models.SummaryModels;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameStore.Web.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public abstract class BaseApiController<TEntity> : ControllerBase where TEntity : BaseEntity
	{
		private readonly GameStoreService<TEntity> _service;
		private readonly Mapper _mapper;

		public BaseApiController(GameStoreService<TEntity> service, Mapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}
		
		[HttpGet("list")]
		public async Task<IList<TEntity>> GetDataList()
		{
			var list = _service.GetAllDataList();
			list = _mapper.Map<Task<IList<TEntity>>>(list);
			return await list;
		}

		[HttpGet("{id}")]
		public async Task<TEntity> GetDataById(Guid id)
		{
			var result = await _service.GetDataById(id);
			result = _mapper.Map<TEntity>(result);
			return result;
		}

		[HttpPost]
		public async Task<TEntity> CreateNewData(TEntity data)
		{
			var create = await _service.CreateNewData(data);
			create = _mapper.Map<TEntity>(create);
			return create;
		}

		[HttpPut("{id}")]
		public async Task UpdateData(TEntity data)
		{
			await _service.UpdataData(data);
		}

		[HttpDelete("{id}")]
		public async Task<TEntity> DeleteData(Guid id)
		{
			var delete = await _service.DeleteData(id);
			delete = _mapper.Map<TEntity>(delete);
			return delete;
		}
	}


}
