using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;

namespace EfCore_Maktab135.Interfaces.Repositories
{
    public interface ICategoryService
    {
        int Create(Category model);
        Category GetById(int id);
        List<GetCategoryDto> GetAll();
        void Update(Category product);
        void Delete(int id);
    }
}
