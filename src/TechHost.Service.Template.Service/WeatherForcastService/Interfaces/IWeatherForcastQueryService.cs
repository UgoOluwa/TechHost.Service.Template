using TechHost.Service.Template.Core.CustomResponses;
using TechHost.Service.Template.Service.Dtos;

namespace TechHost.Service.Template.Service.WeatherForcastService.Interfaces;

public interface IWeatherForcastQueryService
{
    Task<BaseResponse<WeatherForcastDto?>> GetWeatherForcastAsync(Guid id);
    Task<BaseResponse<List<WeatherForcastDto>>> GetAllWeatherForcastsAsync();
}
