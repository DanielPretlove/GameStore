using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities.Entities
{
	public class Customer : BaseEntity
	{
		public virtual string Name { get; set; } = string.Empty;
		public virtual string Address { get; set; } = string.Empty;
		public virtual string DOB { get; set; } = string.Empty;

	}
}
