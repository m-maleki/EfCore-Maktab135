using EfCore_Maktab135.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Infrastructure.Configurations
{
    public class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasOne(x => x.User)
               .WithOne(x => x.UserProfile)
               .HasForeignKey<UserProfile>(x => x.UserId);
        }
    }
}
