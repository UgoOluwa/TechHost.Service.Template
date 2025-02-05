namespace TechHost.Service.Template.Data.RepositoryInterfaces.Commands;

public interface IGenericCommandRepository<T> where T : class
{
    Task<bool> InsertAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(T entity);
}
