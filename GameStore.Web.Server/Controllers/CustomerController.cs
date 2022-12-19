using System.Reflection;
using AutoMapper;
using GameStore.Application.Services;
using GameStore.Data.Entities.Entities;
using GameStore.Web.Shared.Models.SummaryModels;
using Microsoft.AspNetCore.Mvc;


// use DTO
// make it generic 
// start on blazor app 

namespace GameStore.Web.API.Controllers
{
	public class CustomerController : BaseApiController<Customer>
	{
		public CustomerController(GameStoreService<Customer> service, Mapper mapper) : base(service, mapper)
		{
		}
	}
}
