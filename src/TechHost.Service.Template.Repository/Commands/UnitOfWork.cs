using TechHost.Service.Template.Data.Contexts;
using TechHost.Service.Template.Data.RepositoryInterfaces.Commands;
using TechHost.Service.Template.Data.RepositoryInterfaces.Common;
using TechHost.Service.Template.Data.RepositoryInterfaces.Queries;

namespace TechHost.Service.Template.Repository.Commands;

public class UnitOfWork : IUnitOfWOrk
{
    public IWeatherForcastCommadRepository WeatherForcastCommadRepository { get; }
    public IWeatherForcastQueryRepository WeatherForcastQueryRepository { get; }
    private readonly AppDbContext _applicationContext;


    public UnitOfWork(IWeatherForcastCommadRepository weatherForcastCommadRepository, IWeatherForcastQueryRepository weatherForcastQueryRepository, AppDbContext applicationContext)
    {
        WeatherForcastCommadRepository = weatherForcastCommadRepository ?? throw new ArgumentNullException(nameof(weatherForcastCommadRepository)); ;
        WeatherForcastQueryRepository = weatherForcastQueryRepository ?? throw new ArgumentNullException(nameof(weatherForcastQueryRepository)); ;
        _applicationContext = applicationContext;
    }

    public async Task SaveAsync()
    {
        await _applicationContext.SaveChangesAsync();
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _applicationContext.Dispose();
        }
    }

}
