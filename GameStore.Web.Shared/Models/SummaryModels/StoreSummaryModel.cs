using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Web.Shared.Models.SummaryModels
{
	public partial class GameStoreSummaryModel : BaseEntitySummary
	{
        public virtual string Description { get; set; }
		public virtual string Address { get; set; }
	}
}
