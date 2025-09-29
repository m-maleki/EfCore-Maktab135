using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EfCore_Maktab135.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new UserProfileConfig());


            modelBuilder.Entity<Order>()
                .HasMany(x=>x.OrderItems)
                .WithOne(x=>x.Order)
                .HasForeignKey(x=>x.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(x=>x.User)
                .WithMany(x=>x.Orders)
                .HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<OrderItem>()
                .HasOne(x=>x.User)
                .WithMany(x=>x.OrderItems)
                .HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.NoAction); 


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    "Data Source=.;Initial Catalog=Maktab135DB;User ID=sa; Password=123456;Trust Server Certificate=True");
            //Server=localhost;Database=Maktab135Db;user id=sa;password=25915491;trust server certificate=true
            base.OnConfiguring(optionsBuilder);
        }
    }
}
