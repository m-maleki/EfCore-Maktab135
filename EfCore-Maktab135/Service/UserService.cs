using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Enum;
using EfCore_Maktab135.Infrastructure.Repositories;
using EfCore_Maktab135.Interfaces.Repositories;
using EfCore_Maktab135.Interfaces.Services;

namespace EfCore_Maktab135.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository = new UserRepository();
        public GetUserDto Get(int id)
        {
            return _userRepository.Get(id);
        }

        public GetUserDto GetByUsername(string username)
        {
            var user = _userRepository.GetByUsername(username);
            if (user == null)
                throw new Exception("the user not found");

            return user;
            
        }

        public UserRole GetRole(string username)
        {
            return _userRepository.GetRole(username);
        }

        public bool Login(string username, string password)
        {
            return _userRepository.Login(username, password);
        }

        public int Register(CreateUserDto user)
        {
            var model = _userRepository.GetByUsername(user.Username);

            if (model != null && model.username == user.Username)
                throw new Exception("Username was taken");
            if (user.Username.Length <3)
                throw new Exception("Username can not be less than 3 characters");

            return _userRepository.Register(user);
        }
    }
}
