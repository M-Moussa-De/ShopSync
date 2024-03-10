using Microsoft.EntityFrameworkCore;
using ShopSync.Domain.Entities;

namespace ShopSync.Infrastructure.Database
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }

    public partial class ApplicationContext
    {
        public DbSet<Product> Products { get; set; }
    }

}