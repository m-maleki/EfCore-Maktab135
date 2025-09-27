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
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {


            builder.HasData(new List<User>
            {
                new User {Id = 1 , username = "admin" , password = "admin" ,Role = Enum.UserRole.Admin },
                new User {Id = 2 , username = "user" , password = "user" ,Role = Enum.UserRole.User },
            });
        }
    }
}
