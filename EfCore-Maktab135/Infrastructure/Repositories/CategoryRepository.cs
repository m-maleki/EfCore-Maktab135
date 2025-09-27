using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _dbContext = new();

        public int Create(Category model)
        {
            _dbContext.Categories.Add(model);
            _dbContext.SaveChanges();

            return model.Id;
        }

        public Category GetById(int id)
        {
            var category = _dbContext.Categories.FirstOrDefault(x => x.Id == id);

            if (category is null)
                throw new Exception($"category with Id {id} not found");

            return category;
        }

        public List<Category> GetAll()
        {
            return _dbContext.Categories.AsNoTracking().ToList();
        }

        public void Update(Category category)
        {
            var model = _dbContext.Categories.FirstOrDefault(x => x.Id == category.Id);

            if (model is null)
                throw new Exception($"category with Id {category.Id} not found");

            model.Name = category.Name;

            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _dbContext.Categories.FirstOrDefault(x => x.Id == id);

            if (category is null)
                throw new Exception($"category with Id {id} not found");

            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();
        }
    }
}

//Query(Get,GetAll,..)
//Command(add,update,remove)