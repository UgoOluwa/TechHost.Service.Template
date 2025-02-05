using AutoMapper;
using TechHost.Service.Template.Model.Entities;
using TechHost.Service.Template.Service.Dtos;

namespace TechHost.Service.Template.Service.Commons.Mappings;

public class WeatherForcastMapper : Profile
{
    public WeatherForcastMapper()
    {
        CreateMap<CreateWeatherForecastDto, WeatherForecast>();
        CreateMap<WeatherForecast, WeatherForcastDto>().ReverseMap();
    }
}
