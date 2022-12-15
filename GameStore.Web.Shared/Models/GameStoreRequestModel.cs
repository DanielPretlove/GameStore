using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Web.Shared.Models.SummaryModels;

namespace GameStore.Shared.Models
{
	public class GameStoreRequestModel
	{
		public StoreSummaryModel Store { get; set; }
		public CustomerSummaryModel Customer { get; set; }
		public GameSummaryModel Game { get; set; }

		public GameStoreRequestModel(StoreSummaryModel store, CustomerSummaryModel customer, GameSummaryModel game)
		{
			Store = store;
			Customer = customer;
			Game = game;
		}
	}
}
