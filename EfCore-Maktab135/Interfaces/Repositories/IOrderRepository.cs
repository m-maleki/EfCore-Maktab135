using EfCore_Maktab135.Entities;

namespace EfCore_Maktab135.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        public int Create(Order order);
    }

}
