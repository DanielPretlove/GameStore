using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Web.Shared.Models.SummaryModels
{
	public class BaseEntitySummary
	{
		public Guid Id { get; set; }
		public virtual string Name { get; set; } = string.Empty;
	}
}
