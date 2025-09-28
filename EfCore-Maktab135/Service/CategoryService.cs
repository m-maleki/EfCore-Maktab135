using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Infrastructure.Repositories;
using EfCore_Maktab135.Interfaces.Repositories;
using EfCore_Maktab135.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository = new CategoryRepository();

        public int Create(Category model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<GetCategoryDto> GetAll()
        {
            var result = _repository.GetAll();
           return result.ToList();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category product)
        {
            throw new NotImplementedException();
        }
    }
}
