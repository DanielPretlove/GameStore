using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities.Entities
{
	public class Store : BaseEntity
	{
		public required virtual string Description { get; set; }
		public required virtual string Name { get; set; } 
		public required virtual string Address { get; set; }
	}
}
