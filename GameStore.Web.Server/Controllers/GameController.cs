using AutoMapper;
using GameStore.Application.Services;
using GameStore.Data.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Web.API.Controllers
{
	public class GameController : BaseApiController<Game>
	{
		public GameController(GameStoreService<Game> service, Mapper mapper) : base(service, mapper)
		{
		}
	}
}
