using TechHost.Service.Template.Data.RepositoryInterfaces.Commands;
using TechHost.Service.Template.Data.RepositoryInterfaces.Queries;

namespace TechHost.Service.Template.Data.RepositoryInterfaces.Common;

public interface IUnitOfWOrk : IDisposable
{
    #region Weather Forcast Repository
    IWeatherForcastCommadRepository WeatherForcastCommadRepository { get; }
    IWeatherForcastQueryRepository WeatherForcastQueryRepository { get; }
    #endregion

    Task SaveAsync();
}
