using ShopSync.Domain.Entities;

namespace ShopSync.Domain.Contracts
{
    public interface IUnitOfWork
    {
        #region Repos
        public IGenericRepository<Product> ProductRepository { get; }
        #endregion

        public bool Save();
        public Task<bool> SaveAsync();
    }
}