using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Shared.Models
{
	public class GameStoreRequestModel
	{
		public StoreSummaryModel Store { get; set; }
		public CustomerSummaryModel Customer { get; set; }
		public GameSummaryModel Game { get; set; }
	}
}
