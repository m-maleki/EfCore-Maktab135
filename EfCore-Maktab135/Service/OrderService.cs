using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Infrastructure.Repositories;
using EfCore_Maktab135.Interfaces.Repositories;
using EfCore_Maktab135.Interfaces.Services;

namespace EfCore_Maktab135.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository = new OrderRepository();

        public int Create(Order order)
        {
            order.CreatedAt = DateTime.Now;
            return _repository.Create(order);
        }

        public List<GetUserOrderDto> GetUserOrders(int userId)
        {
            return _repository.GetOrders(userId);
        }
    }
}
