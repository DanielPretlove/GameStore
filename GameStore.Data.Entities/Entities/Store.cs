﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities.Entities
{
	public class Store : BaseEntity
	{
		public virtual string Description { get; set; } = string.Empty;
		public virtual string Name { get; set; } = string.Empty;
		public virtual Customers? customer { get; set; }
		public virtual Games? games { get; set; }



	}
}