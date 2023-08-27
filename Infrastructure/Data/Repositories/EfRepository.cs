using Infrastructure.Data.Interfaces;
using Infrastructure.Entities;

namespace Infrastructure.Data.Repositories
{
    public class EfRepository<T> : IAsyncEfRepository<T> where T : BaseEntity
    {
        //protected readonly ApplicationContext _dbContext;

        //public EfRepository(ApplicationContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> AddAsync(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> DeleteAsync(List<T> entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> UpdateAsync(List<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
