using ApplicationCore.Interfaces;

namespace Infrastructure.Data
{
    public class AppRepository<T> : RepositoryBase<T>, IRepository<T> where T : class 
    {
        public AppRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
