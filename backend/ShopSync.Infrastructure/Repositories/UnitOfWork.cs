using ShopSync.Domain.Contracts;
using ShopSync.Domain.Entities;
using ShopSync.Infrastructure.Database;

namespace ShopSync.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private IGenericRepository<Product> _productRepository;
        private bool _dispoased = false;

        public UnitOfWork(
            ApplicationContext context,
            IGenericRepository<Product> productRepository
        )
        {
            _context = context;
            _productRepository = productRepository;
        }

        public IGenericRepository<Product> ProductRepository => _productRepository;

        #region  Operations
        public virtual bool Save()
        {
            bool result = false;
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.SaveChanges();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("An error occurred during the save operation", ex);
                }
            }

            return result;
        }
        public virtual async Task<bool> SaveAsync()
        {
            bool result = false;
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.SaveChangesAsync();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("An error occurred during the save operation", ex);
                }
            }

            return result;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_dispoased)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _dispoased = true;
        }
        #endregion
    }
}