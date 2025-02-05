using AutoMapper;
using TechHost.Service.Template.Application.WeatherForecast.Commands.Create;
using TechHost.Service.Template.Service.Dtos;

namespace TechHost.Service.Template.Application.Commons.Mappings;

public class WeatherForcastMapper : Profile
{
    public WeatherForcastMapper()
    {
        CreateMap<CreateWeatherForecastCommand, CreateWeatherForecastDto>().ReverseMap();

        //CreateMap<CreateWeatherForecastCommand, WeatherForcastDto>().ReverseMap();
    }
}
