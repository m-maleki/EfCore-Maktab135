using EfCore_Maktab135.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EfCore_Maktab135.Infrastructure.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.HasData(new List<Category>()
            {
                new Category() { Id = 1, Name = "Mobile" },
                new Category() { Id = 2, Name = "Pc" },
                new Category() { Id = 3, Name = "Laptop" }
            });
        }
    }
}
