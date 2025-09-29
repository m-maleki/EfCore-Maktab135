using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Interfaces.Services
{
    public interface IUserService
    {
        public bool Login(string username, string password);
        public int Register(CreateUserDto user);
        public GetUserDto Get(int id);
        public GetUserDto GetByUsername(string username);
        public UserRole GetRole(string username);
    }
}
