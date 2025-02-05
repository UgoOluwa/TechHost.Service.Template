using MediatR;
using TechHost.Service.Template.Application.Commons.Bases;
using TechHost.Service.Template.Service.Dtos;

namespace TechHost.Service.Template.Application.WeatherForecast.Queries.GetAll;

public record GetAllQuery() : IRequest<BaseResponse<List<WeatherForcastDto>>>;