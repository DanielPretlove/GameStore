using AutoMapper;
using GameStore.Application.Services;
using GameStore.Data.Access.Repositories;
using GameStore.Data.Entities.Entities;
using GameStore.Web.Shared.Models.SummaryModels;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Web.API.Controllers
{
	public class GameStoreController : BaseApiController<Store>
	{
		public GameStoreController(GameStoreService<Store> service, Mapper mapper) : base(service, mapper)
		{
		}
	}
}
