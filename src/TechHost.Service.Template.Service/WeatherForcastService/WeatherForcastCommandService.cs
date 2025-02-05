using Microsoft.Extensions.Logging;
using TechHost.Service.Template.Core.CustomResponses;
using TechHost.Service.Template.Data.RepositoryInterfaces.Commands;
using TechHost.Service.Template.Data.RepositoryInterfaces.Common;
using TechHost.Service.Template.Model.Entities;
using TechHost.Service.Template.Service.Dtos;
using TechHost.Service.Template.Service.WeatherForcastService.Interfaces;

namespace TechHost.Service.Template.Service.WeatherForcastService;

public class WeatherForcastCommandService : IWeatherForcastCommandService
{
    public readonly IUnitOfWOrk _unitOfWOrk;
    private readonly ILogger<WeatherForcastCommandService> _logger;
    private const string ClassName = "weatherForcast";

    public WeatherForcastCommandService(ILogger<WeatherForcastCommandService> logger, IUnitOfWOrk unitOfWOrk)
    {
        _logger = logger;
        _unitOfWOrk = unitOfWOrk;
    }

    public async Task<BaseResponse<CreateWeatherForcastResponseDto>> CreateWeatherForcast(CreateWeatherForecastDto request)
    {
        try
        {
            var newEntity = new WeatherForecast(request.Date, request.TemperatureC, request.Summary);
            var isSuccessful = await _unitOfWOrk.WeatherForcastCommadRepository.InsertAsync(newEntity);
            if (!isSuccessful) {
                return new BaseResponse<CreateWeatherForcastResponseDto>(null, false, string.Empty, ResponseMessages.SetCreationFailureMessage(ClassName));
            }

            await _unitOfWOrk.SaveAsync();
            return new BaseResponse<CreateWeatherForcastResponseDto>(new CreateWeatherForcastResponseDto(newEntity.Id), true, string.Empty, ResponseMessages.SetCreationSuccessMessage(ClassName));
        }
        catch (Exception ex) {
            _logger.LogError(ex.ToString());
            return new BaseResponse<CreateWeatherForcastResponseDto>(null, false, string.Empty, ex.Message);
        }
        
    }
}
