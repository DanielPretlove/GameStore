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
	public abstract class BaseApiController<T> : ControllerBase where T : BaseEntity
	{
		private readonly GameStoreService<T> _service;
		private readonly Mapper _mapper;

		public BaseApiController(GameStoreService<T> service, Mapper mapper)
		{
			_service = service;
			_mapper = mapper;
		}
		
		[HttpGet("list")]
		public async Task<IList<T>> GetDataList()
		{
			var list = _service.GetAllDataList();
			list = _mapper.Map<Task<IList<T>>>(list);
			return await list;
		}

		[HttpGet("{id}")]
		public async Task<T> GetDataById(Guid id)
		{
			var result = await _service.GetDataById(id);
			result = _mapper.Map<T>(result);
			return result;

		}

		[HttpPost]
		public async Task<T> CreateNewData(T data)
		{
			var create = await _service.CreateNewData(data);
			create = _mapper.Map<T>(create);
			return create;
		}

		[HttpPut("{id}")]
		public async Task UpdateData(T data)
		{
			await _service.UpdataData(data);
		}

		[HttpDelete("{id}")]
		public async Task<T> DeleteData(Guid id)
		{
			var delete = await _service.DeleteData(id);
			delete = _mapper.Map<T>(delete);
			return delete;
		}
	}


}
