using MediatR;
using TechHost.Service.Template.Application.Commons.Bases;

namespace TechHost.Service.Template.Application.WeatherForecast.Commands.Create;

public record CreateWeatherForecastCommand(DateOnly Date, int TemperatureC, string? Summary) : IRequest<BaseResponse<Guid?>>;