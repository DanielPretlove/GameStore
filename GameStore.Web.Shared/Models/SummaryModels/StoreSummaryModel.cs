using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Data.Entities.Entities;

namespace GameStore.Web.Shared.Models.SummaryModels
{
	public partial class StoreSummaryModel : BaseEntitySummary
	{
		public required virtual string Description { get; set; }
		public required virtual string Name { get; set; }
		public required virtual string Address { get; set; }
	}
}
