using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GameStore.Data.Entities.Entities;
using GameStore.Web.Shared.Models.SummaryModels;

namespace GameStore.Common.Helpers
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles() 
		{
			CreateMap<Customer, CustomerSummaryModel>();
			CreateMap<Store, StoreSummaryModel>();
			CreateMap<Game, GameSummaryModel>();
		}
	}
}
