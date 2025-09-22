using EfCore_Maktab135.Entities;

namespace EfCore_Maktab135.Interfaces.Services;

public interface IOrderService
{
    public int Create(Order order);
}