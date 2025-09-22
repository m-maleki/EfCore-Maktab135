using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCore_Maktab135.Entities;

namespace EfCore_Maktab135.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        int Create(Category model);
        Category GetById(int id);
        List<Category> GetAll();
        void Update(Category product);
        void Delete(int id);
    }
}
