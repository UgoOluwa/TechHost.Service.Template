using TechHost.Service.Template.Core.CustomResponses;
using TechHost.Service.Template.Service.Dtos;

namespace TechHost.Service.Template.Service.WeatherForcastService.Interfaces;

public interface IWeatherForcastCommandService
{
    Task<BaseResponse<CreateWeatherForcastResponseDto>> CreateWeatherForcast(CreateWeatherForecastDto request);
}
