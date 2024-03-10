using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ShopSync.Domain.Contracts;
using ShopSync.Infrastructure.Database;

namespace ShopSync.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly ApplicationContext _context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(
            Expression<Func<TEntity, bool>> filter = null,
            int? page = null,
            int pageSize = 10,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            bool noTrack = false,
            params Expression<Func<TEntity, object>>[] includeProperties
        )
        {
            IQueryable<TEntity> query = _dbSet;

            query = ApplyFilterNoTrackAndIncludes(filter, noTrack, includeProperties, query);

            if (orderBy != null) query = orderBy(query);

            if (page.HasValue && page > 0) query = query.Skip((page.Value - 1) * pageSize).Take(pageSize);

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetFirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> filter = null,
        bool noTrack = false,
        params Expression<Func<TEntity, object>>[] includeProperties
       )
        {
            IQueryable<TEntity> query = _dbSet;

            query = ApplyFilterNoTrackAndIncludes(filter, noTrack, includeProperties, query);

            return await query.FirstOrDefaultAsync();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            Update(entity);
        }

        private static IQueryable<TEntity> ApplyFilterNoTrackAndIncludes(Expression<Func<TEntity, bool>> filter, bool noTrack, Expression<Func<TEntity, object>>[] includeProperties, IQueryable<TEntity> query)
        {
            if (filter != null) query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            if (noTrack) query = query.AsNoTracking();

            return query;
        }
    }
}