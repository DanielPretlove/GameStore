using GameStore.Application.Services;
using GameStore.Common.Helpers;
using GameStore.Data.Access.Repositories;
using GameStore.Data.Access.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace GameStore.Common.Extensions
{
	public static class ConfigureContainer
	{
		public static IServiceCollection AddConfigureContainer(this IServiceCollection services, IConfiguration config)
		{

			services.AddScoped(typeof(GameStoreService<>));
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
			services.AddDbContext<GameStoreDataContext>(options => 
			{
				options.UseSqlServer(config.GetConnectionString("GameStoreDB"), b => b.MigrationsAssembly("GameStore.Web.API"));
			});

			return services;
		}
	}
}
