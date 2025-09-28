using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Enum;
using EfCore_Maktab135.Infrastructure.Repositories;
using EfCore_Maktab135.Interfaces.Repositories;
using EfCore_Maktab135.Interfaces.Services;

namespace EfCore_Maktab135.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository = new UserRepository();
        public GetUserDto Get(int id)
        {
            return userRepository.Get(id);
        }

        public UserRole GetRole(string username)
        {
            return userRepository.GetRole(username);
        }

        public bool Login(string username, string password)
        {
            return userRepository.Login(username, password);
        }

        public int Register(CreateUserDto user)
        { 
            return userRepository.Register(user);
        }
    }
}
