using System.Reflection;
using GameStore.Application.Services;
using GameStore.Data.Entities.Entities;
using GameStore.Web.Shared.Models.SummaryModels;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Web.API.Controllers
{
	public class CustomerController : BaseApiController
	{
		private readonly GameStoreService<Customer> _service;
		public CustomerController(GameStoreService<Customer> service)
		{
			_service = service;
		}

		[HttpGet("customer/list")]
		public async Task<IList<Customer>> GetCustomerList()
		{
			var customers = await _service.GetAllDataList();
			return customers;
		}

		[HttpGet("customer/{id:Guid}")]
		public async Task<Customer> GetCustomerById(Guid id)
		{
			var result = await _service.GetDataById(id);
			return result;

		}

		[HttpPost("customer")]
		public async Task<Customer> CreateNewCustomer(Customer customer)
		{
			return await _service.CreateNewData(customer);
		}

		[HttpPut("customer")]
		public async Task UpdateCustomer(Customer customer)
		{
			await _service.UpdataData(customer);
		}

		[HttpDelete("customer/{id}")]
		public async Task<Customer> DeleteCustomer(Guid id)
		{
			return await _service.DeleteData(id);
		}
	}
}
