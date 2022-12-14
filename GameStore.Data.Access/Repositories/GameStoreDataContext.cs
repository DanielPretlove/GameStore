using System.Reflection;
using GameStore.Data.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data.Access.Repositories
{
	
	public class GameStoreDataContext : DbContext
	{
		public GameStoreDataContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			foreach(var entityType in Assembly
				.GetAssembly(typeof(BaseEntity))
				.GetTypes()
				.Where(n => n.BaseType == typeof(BaseEntity)))
			{
				modelBuilder.Entity(entityType);
			}
		}
	}
}
