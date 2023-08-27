using Infrastructure.Entities;

namespace Infrastructure.Data.Interfaces;

public interface IAsyncEfRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(Guid id);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<List<T>> AddAsync(List<T> entity);
    Task<List<T>> DeleteAsync(List<T> entity);
    Task<List<T>> UpdateAsync(List<T> entity);
}
