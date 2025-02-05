using MediatR;
using TechHost.Service.Template.Application.Commons.Bases;
using TechHost.Service.Template.Service.Dtos;
using TechHost.Service.Template.Service.WeatherForcastService.Interfaces;

namespace TechHost.Service.Template.Application.WeatherForecast.Queries.GetAll;

public class GetAllQueryHandler : IRequestHandler<GetAllQuery, BaseResponse<List<WeatherForcastDto>>>
{
    public readonly IWeatherForcastQueryService _weatherForcastQueryService;

    public GetAllQueryHandler(IWeatherForcastQueryService weatherForcastQueryService)
    {
        _weatherForcastQueryService = weatherForcastQueryService;
    }

    public async Task<BaseResponse<List<WeatherForcastDto>>> Handle(GetAllQuery query, CancellationToken cancellationToken)
    {
        var response = await _weatherForcastQueryService.GetAllWeatherForcastsAsync();
        return new BaseResponse<List<WeatherForcastDto>>(response.IsSuccessful, response.Data, response.Message, null);
    }
}
