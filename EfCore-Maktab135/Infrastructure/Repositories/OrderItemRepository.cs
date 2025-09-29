using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCore_Maktab135.Dtos;

namespace EfCore_Maktab135.Infrastructure.Repositories
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly AppDbContext _dbContext = new();

        public void Add(List<OrderItem> orderItems)
        {
            _dbContext.OrderItems.AddRange(orderItems);
            _dbContext.SaveChanges();
        }

        public List<GetOrderItemDto> GetUserOrderItems()
        {
            var orderItem = _dbContext.OrderItems.Select(x => new GetOrderItemDto()
            {
                Count = x.Count,
                Price = x.Price,
                ProductName = x.Product.Name
            }).ToList();
            return orderItem;
        }
    }
}
