using System.ComponentModel.DataAnnotations;

namespace TechHost.Service.Template.Model.Entities;

public class WeatherForecast : BaseEntity
{
    [Required]
    public DateOnly Date { get; set; }

    [Required]
    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    [StringLength(500)]
    public string? Summary { get; set; }

    public WeatherForecast(){ }

    public WeatherForecast(DateOnly date, int temperatureC, string? summary)
    {
        Id = Guid.NewGuid();
        DateCreated = DateTime.UtcNow;
        DateModified = DateTime.UtcNow;
        Date = date;
        TemperatureC = temperatureC;
        Summary = summary;
    }
}
