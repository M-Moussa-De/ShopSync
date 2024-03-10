using ShopSync.Domain.Entities;

namespace ShopSync.Infrastructure.Database.Seeds
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Product one", Description = "This is the 1st product's description", BriefDescription = "Brief desc for 1st product", Quantity = 100, Image = "test/path/to/product1/img", Brand = "Test Brand 1", Price = 100000 },
                new Product { Id = Guid.NewGuid(), Name = "Product two", Description = "This is the 2nd product's description", BriefDescription = "Brief desc for 2nd product", Quantity = 90, Image = "test/path/to/product2/img", Brand = "Test Brand 2", Price = 150000 },
                new Product { Id = Guid.NewGuid(), Name = "Product three", Description = "This is the 3red product's description", BriefDescription = "Brief desc for 3rd product", Quantity = 177, Image = "test/path/to/product3/img", Brand = "Test Brand", Price = 175000 }
            };

            context.Products.AddRange(products);

            context.SaveChanges();
        }

    }
}