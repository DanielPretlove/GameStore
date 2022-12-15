using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Entities.Entities
{
	public class Game : BaseEntity
	{
		public virtual string Name { get; set; } = string.Empty;
		public virtual string Description { get; set; } = string.Empty;
		public virtual string ReleaseDate { get; set; } = string.Empty;
	}
}
