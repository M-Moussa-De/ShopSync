using System.Linq.Expressions;

namespace ShopSync.Domain.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        public Task<IEnumerable<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>> filter = null,
            int? page = null,
            int pageSize = 10,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderyBy = null,
            bool noTrack = false,
            params Expression<Func<TEntity, object>>[] includeProperties
        );

        public Task<TEntity> GetFirstOrDefaultAsync(
           Expression<Func<TEntity, bool>> filter = null,
           bool noTrack = false,
          params Expression<Func<TEntity, object>>[] includeProperties
        );

        public Task CreateAsync(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
    }
}