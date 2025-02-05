using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using TechHost.Service.Template.Service.WeatherForcastService;
using TechHost.Service.Template.Service.WeatherForcastService.Interfaces;

namespace TechHost.Service.Template.Service;

public static class ConfigureServices
{
    public static IServiceCollection AddInjectionService(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IWeatherForcastQueryService, WeatherForcastQueryService>();
        services.AddScoped<IWeatherForcastCommandService, WeatherForcastCommandService>();

        return services;
    }
}
