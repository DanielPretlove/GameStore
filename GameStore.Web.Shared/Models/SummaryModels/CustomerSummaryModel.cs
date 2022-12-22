using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Web.Shared.Models.SummaryModels
{
	public class CustomerSummaryModel : BaseEntitySummary
	{
		public virtual string Address { get; set; } = string.Empty;
		public virtual string DOB { get; set; } = string.Empty;
	}
}
