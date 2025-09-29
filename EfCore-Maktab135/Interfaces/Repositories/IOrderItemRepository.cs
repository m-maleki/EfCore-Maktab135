using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;

namespace EfCore_Maktab135.Interfaces.Repositories;

public interface IOrderItemRepository
{
    void Add(List<OrderItem> orderItems);
    List<GetOrderItemDto> GetUserOrderItems();
}