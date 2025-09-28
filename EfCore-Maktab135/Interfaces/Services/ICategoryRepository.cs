using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Interfaces.Services
{
    public interface ICategoryRepository
    {
        int Create(Category model);
        Category GetById(int id);
        IEnumerable<GetCategoryDto> GetAll();
        void Update(Category product);
        void Delete(int id);
    }
}
