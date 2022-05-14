using ApplicationCore.Interfaces;

namespace Infrastructure.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly AppDbContext _dbContext;

        public RepositoryBase(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<T> GetById(int Id)
        {
            return await _dbContext.Set<T>().FindAsync(new object[] { Id });
        }
        public async Task<T> Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}