using AutoMapper;
using MediatR;
using TechHost.Service.Template.Application.Commons.Bases;
using TechHost.Service.Template.Service.Dtos;
using TechHost.Service.Template.Service.WeatherForcastService.Interfaces;

namespace TechHost.Service.Template.Application.WeatherForecast.Commands.Create;

public class CreateWeatherForecastCommandHandler : IRequestHandler<CreateWeatherForecastCommand, BaseResponse<Guid?>>
{
    public readonly IWeatherForcastCommandService _commandService;
    public readonly IMapper _mapper;
    public CreateWeatherForecastCommandHandler(IWeatherForcastCommandService commandService, IMapper mapper)
    {
        _commandService = commandService;
        _mapper = mapper;
    }
    public async Task<BaseResponse<Guid?>> Handle(CreateWeatherForecastCommand request, CancellationToken cancellationToken)
    {
        var response = await _commandService.CreateWeatherForcast(_mapper.Map<CreateWeatherForecastDto>(request));
        
        return new BaseResponse<Guid?>(response.IsSuccessful, response?.Data?.Id, response?.Message, null);
    }
}
