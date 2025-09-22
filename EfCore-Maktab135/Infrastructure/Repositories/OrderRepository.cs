using EfCore_Maktab135.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCore_Maktab135.Entities;

namespace EfCore_Maktab135.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbContext = new();

        public int Create(Order order)
        {
           _dbContext.Orders.Add(order);
           _dbContext.SaveChanges();

           return order.Id;
        }
    }
}
