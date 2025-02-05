using System.Linq.Expressions;
using TechHost.Service.Template.Service.RepositoryInterfaces.Common;

namespace TechHost.Service.Template.Data.RepositoryInterfaces.Queries;

public interface IGenericQueryRepository<T> where T : class
{
    Task<T?> GetByAsync(Expression<Func<T, bool>> predicate, FindOptions? findOptions = null);
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate, FindOptions? findOptions = null);
    Task<IEnumerable<T>> GetAllAsync(FindOptions? findOptions = null);
    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
    Task<int> CountAsync(Expression<Func<T, bool>> predicate);
}
