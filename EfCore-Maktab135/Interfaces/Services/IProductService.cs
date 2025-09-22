using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;

namespace EfCore_Maktab135.Interfaces.Services;

public interface IProductService
{
    int Create(Product model);
    Product GetById(int id);
    List<GetProductDto> GetAll();
    void Update(Product product);
    void Delete(int id);
}