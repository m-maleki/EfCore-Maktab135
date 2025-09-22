using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Interfaces.Repositories
{
    public interface IProductRepository
    {
        int Create(Product model);
        Product GetById(int id);
        List<GetProductDto> GetAll();
        void Update(Product product);
        void Delete(int id);
    }
}
