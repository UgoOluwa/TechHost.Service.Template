using TechHost.Service.Template.Data.Contexts;
using TechHost.Service.Template.Data.RepositoryInterfaces.Queries;
using TechHost.Service.Template.Model.Entities;

namespace TechHost.Service.Template.Repository.Queries;

public class WeatherForcastQueryRepository : GenericQueryRepository<WeatherForecast>, IWeatherForcastQueryRepository
{
    public WeatherForcastQueryRepository(AppDbContext dbContext) 
        : base(dbContext)
    {
        
    }
}
