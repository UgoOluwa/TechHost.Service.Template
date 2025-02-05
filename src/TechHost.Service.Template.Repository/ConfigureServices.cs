using Microsoft.Extensions.DependencyInjection;
using TechHost.Service.Template.Data.Contexts;
using TechHost.Service.Template.Data.RepositoryInterfaces.Commands;
using TechHost.Service.Template.Data.RepositoryInterfaces.Common;
using TechHost.Service.Template.Data.RepositoryInterfaces.Queries;
using TechHost.Service.Template.Repository.Commands;
using TechHost.Service.Template.Repository.Queries;

namespace TechHost.Service.Template.Repository;

public static class ConfigureServices
{
    public static IServiceCollection AddInjectionRepository(this IServiceCollection services)
    {
        services.AddScoped<AppDbContext>();
        services.AddScoped<IUnitOfWOrk, UnitOfWork>();
        services.AddScoped<IWeatherForcastCommadRepository, WeatherForcastCommandRepository>();
        services.AddScoped<IWeatherForcastQueryRepository, WeatherForcastQueryRepository>();
        services.AddScoped(typeof(IGenericCommandRepository<>), typeof(GenericCommandRepository<>));
        services.AddScoped(typeof(IGenericQueryRepository<>), typeof(GenericQueryRepository<>));

        return services;
    }
}
