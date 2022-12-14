using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities.Entities
{
	public class Store : BaseModel
	{
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public Customers customers { get; set; }


		public Store() { }

	}
}
