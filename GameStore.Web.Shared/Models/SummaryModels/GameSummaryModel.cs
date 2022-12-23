using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Web.Shared.Models.SummaryModels
{
	public class GameSummaryModel : BaseEntitySummary
	{
        public virtual string Description { get; set; } = string.Empty;
		public virtual string ReleaseDate { get; set; } = string.Empty;
	}
}
