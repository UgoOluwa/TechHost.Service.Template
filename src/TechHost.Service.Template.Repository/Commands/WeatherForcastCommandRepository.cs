using TechHost.Service.Template.Data.Contexts;
using TechHost.Service.Template.Data.RepositoryInterfaces.Commands;
using TechHost.Service.Template.Model.Entities;

namespace TechHost.Service.Template.Repository.Commands;

public class WeatherForcastCommandRepository : GenericCommandRepository<WeatherForecast>, IWeatherForcastCommadRepository
{
    public WeatherForcastCommandRepository(AppDbContext dbContext)
        : base(dbContext)
    {
        
    }
}
