using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Interfaces.Services;
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

        public IEnumerable<GetCategoryDto> GetAll()
        {
            return _dbContext.Categories.AsNoTracking()
                .Select(x=>new GetCategoryDto
                {
                    Id = x.Id,
                    Name = x.Name,
                });
        }

        public void Update(Category category)
        {
            _dbContext.Categories
                .Where(x => x.Id == category.Id)
                .ExecuteUpdate(set => set
                .SetProperty(c => c.Name, category.Name)
                .SetProperty(c => c.CreatedAt, DateTime.Now));

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