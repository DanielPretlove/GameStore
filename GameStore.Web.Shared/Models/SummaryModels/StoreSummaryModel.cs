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
		public virtual string Description { get; set; } = string.Empty;
		public virtual string Name { get; set; } = string.Empty;
		public virtual Customer? Customer { get; set; }
		public virtual Game? Game { get; set; }
	}
}
