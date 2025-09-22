using EfCore_Maktab135.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCore_Maktab135.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new List<Category>()
            {
                new Category() { Id = 1, Name = "Mobile" },
                new Category() { Id = 2, Name = "Pc" },
                new Category() { Id = 3, Name = "Laptop" }
            });

            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {
                new Product(){Id = 1 , Name = "Iphone 16" ,Color = "Black" , CreateAt = new DateTime(2025,09,22) , Price = 9000000 , CategoryId = 1,Count = 10},
                new Product(){Id = 2 , Name = "Iphone 10" ,Color = "Silver" , CreateAt = new DateTime(2025,09,22) , Price = 2000000 , CategoryId = 1,Count = 30},
                new Product(){Id = 3 , Name = "Asus N510" ,Color = "Black" , CreateAt = new DateTime(2025,09,22) , Price = 3500000 , CategoryId = 3,Count = 20},
            });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    "Server=localhost;Database=Maktab135Db;user id=sa;password=25915491;trust server certificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
