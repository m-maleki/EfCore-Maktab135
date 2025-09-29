using EfCore_Maktab135.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCore_Maktab135.Dtos;
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

        public List<GetUserOrderDto> GetOrders(int userId)
        {
            var orders = _dbContext.Orders.Where(x => x.UserId == userId)
                .Select(x => new GetUserOrderDto()
                {
                    Id = x.Id,
                    CreateAt = x.CreatedAt,
                    TotalPrice = x.TotalPrice,
                    OrderItems = x.OrderItems.Select(o => new GetOrderItemDto()
                    {
                        Price = o.Price,
                        Count = o.Count,
                        ProductName = o.Product.Name
                        
                    }).ToList()
                }).ToList();

            return orders;
        }
    }
}
