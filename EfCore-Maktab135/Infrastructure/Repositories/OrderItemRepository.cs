using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Infrastructure.Repositories
{
    public class OrderItemRepository
    {
        private readonly AppDbContext _dbContext = new();

        public void Add(List<OrderItem> orderItems)
        {
            _dbContext.OrderItems.AddRange(orderItems);
            _dbContext.SaveChanges();
        }
    }
}
