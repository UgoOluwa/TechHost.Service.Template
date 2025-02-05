using Microsoft.EntityFrameworkCore;
using TechHost.Service.Template.Data.Contexts;
using TechHost.Service.Template.Data.RepositoryInterfaces.Commands;

namespace TechHost.Service.Template.Repository.Commands;

public class GenericCommandRepository<T> : IGenericCommandRepository<T> where T : class
{
    private readonly AppDbContext _applicationContext;

    public GenericCommandRepository(AppDbContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<bool> InsertAsync(T entity)
    {
        var response = await _applicationContext.Set<T>().AddAsync(entity);
        return response.State == EntityState.Added;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        var response = _applicationContext.Set<T>().Update(entity);
        return response.State == EntityState.Modified;
    }

    public async Task<bool> DeleteAsync(T entity)
    {
        var response = _applicationContext.Set<T>().Remove(entity);
        return response.State == EntityState.Deleted;
    }
}
