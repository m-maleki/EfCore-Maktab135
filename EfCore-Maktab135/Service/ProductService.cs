using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Infrastructure.Repositories;
using EfCore_Maktab135.Interfaces.Repositories;
using EfCore_Maktab135.Interfaces.Services;

namespace EfCore_Maktab135.Service;
public class ProductService : IProductService
{
    private readonly IProductRepository _repository = new ProductRepository();

    public int Create(Product model)
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<GetProductDto> GetAll()
    {
        return _repository.GetAll();
    }

    public void Update(Product product)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}
