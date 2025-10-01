using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ChangeTracker

namespace EfCore_Maktab135.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbContext = new();

        public int Create(Product model)
        {
            _dbContext.Products.Add(model);
            _dbContext.SaveChanges();

            return model.Id;
        }

        public Product GetById(int id)
        {
            var product = _dbContext.Products
                .AsNoTracking()
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);

            if (product is null)
                throw new Exception("product with id {id} not found");

            return product;
        }

        public List<GetProductDto> GetAll(int page, int pageSize)
        {
            var data = _dbContext.Products
                .AsNoTracking()
                .Include(x => x.Category)
                .Select(x => new GetProductDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Color = x.Color,
                    Price = x.Price,
                    CategoryName = x.Category.Name,
                    Count = x.Count
                }).Skip((page - 1 )* pageSize).Take(pageSize);

            var query = data.ToQueryString();

            return data.ToList();
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
}
