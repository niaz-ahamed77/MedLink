using Microsoft.Identity.Client;

namespace Project.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(int id);
        Task<IQueryable<T>> GetAll();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
