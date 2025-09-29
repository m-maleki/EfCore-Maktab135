using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;

namespace EfCore_Maktab135.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        public int Create(Order order);
        public List<GetUserOrderDto> GetOrders(int userId);

    }

}
