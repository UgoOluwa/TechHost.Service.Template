namespace TechHost.Service.Template.Service.Dtos;

public record CreateWeatherForecastDto(DateOnly Date, int TemperatureC, string? Summary);