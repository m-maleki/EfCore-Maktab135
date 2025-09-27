using EfCore_Maktab135.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Infrastructure.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);

            builder.HasData(new List<Product>()
            {
                new Product(){Id = 1 , Name = "Iphone 16" ,Color = "Black" , CreateAt = new DateTime(2025,09,22) , Price = 9000000 , CategoryId = 1,Count = 10},
                new Product(){Id = 2 , Name = "Iphone 10" ,Color = "Silver" , CreateAt = new DateTime(2025,09,22) , Price = 2000000 , CategoryId = 1,Count = 30},
                new Product(){Id = 3 , Name = "Asus N510" ,Color = "Black" , CreateAt = new DateTime(2025,09,22) , Price = 3500000 , CategoryId = 3,Count = 20},
            });
        }
    }
}
