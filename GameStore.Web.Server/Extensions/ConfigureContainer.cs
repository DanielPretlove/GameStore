using GameStore.Application.Services;
using GameStore.Data.Access.Repositories;
using GameStore.Data.Access.Repositories.Interfaces;
using GameStore.Web.API.Helpers;
using Microsoft.EntityFrameworkCore;


namespace GameStore.Common.Extensions
{
	public static class ConfigureContainer
	{
		public static IServiceCollection AddConfigureContainer(this IServiceCollection services, IConfiguration config)
		{

			services.AddScoped(typeof(GameStoreService<>));
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
			services.AddScoped(typeof(AutoMapper.Mapper));
			services.AddDbContext<GameStoreDataContext>(options => 
			{
				options.UseSqlServer(config.GetConnectionString("GameStoreDB"), b => b.MigrationsAssembly("GameStore.Web.Server"));
			});

			return services;
		}
	}
}
