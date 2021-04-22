using Microsoft.EntityFrameworkCore;

namespace StoreWebApplication.Mvc.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 1, CategoryName = "Category1"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 2, CategoryName = "Category2"});
            modelBuilder.Entity<Category>().HasData(new Category {CategoryId = 3, CategoryName = "Category3"});

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                CategoryId = 1,
                ProductName = "Lorem ipsum 1", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 9.56M,
                OnStock = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                CategoryId = 2,
                ProductName = "Lorem ipsum 2", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 59.99M,
                OnStock = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                CategoryId =3,
                ProductName = "Lorem ipsum 3", 
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = 10.50M,
                OnStock = true
            });
        }
    }
}
