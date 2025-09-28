using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Enum;

namespace EfCore_Maktab135.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public bool Login(string username, string password);
        public int Register(CreateUserDto user);
        public GetUserDto Get(int id);
        public List<GetUserDto> GetAll();
        public UserRole GetRole(string username);
    }
}
