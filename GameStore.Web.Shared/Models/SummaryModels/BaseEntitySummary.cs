using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Web.Shared.Models.SummaryModels
{
	public class BaseEntitySummary
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
	}
}
