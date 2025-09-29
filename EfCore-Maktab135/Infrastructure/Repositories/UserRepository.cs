using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Enum;
using EfCore_Maktab135.Interfaces.Repositories;

namespace EfCore_Maktab135.Infrastructure.Repositories
{

    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext = new();

        public GetUserDto Get(int id)
        {
           var user = _dbContext.Users
                .Where(u => u.Id == id)
                .Select(u=> new GetUserDto
                {
                    Id = u.Id,
                    username = u.username,
                    FullName = $"{u.UserProfile.FirstName} {u.UserProfile.LastName}",
                    Mobile = u.UserProfile.Mobile
                }).First();

            return user;
        }

        public GetUserDto? GetByUsername(string username)
        {
            var user = _dbContext.Users
                .Where(u => u.username == username)
                .Select(u => new GetUserDto
                {
                    Id = u.Id,
                    username = u.username,
                    FullName = $"{u.UserProfile.FirstName} {u.UserProfile.LastName}",
                    Mobile = u.UserProfile.Mobile
                }).FirstOrDefault();

            return user;
        }

        public List<GetUserDto> GetAll()
        {
            var users = _dbContext.Users
             .Select(u => new GetUserDto
             {
                 Id = u.Id,
                 username = u.username,
                 FullName = $"{u.UserProfile.FirstName} {u.UserProfile.LastName}",
                 Mobile = u.UserProfile.Mobile
             }).ToList();

            return users;
        }

        public UserRole GetRole(string username)
        {
            var userRole = _dbContext.Users
                .Where(u => u.username == username)
                .Select(x=>x.Role)
                .First();

            return userRole;
        }

        public bool Login(string username, string password)
        {
           return _dbContext.Users.Any(u => u.username == username && u.password == password);
        }

        public int Register(CreateUserDto user)
        {
            var entity = new User
            {
                username = user.Username,
                password = user.Password,
                Role = Enum.UserRole.User,
                UserProfile = new UserProfile
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Mobile = user.Mobile,
                }
            };

            _dbContext.Users.Add(entity);

            _dbContext.SaveChanges();

            return entity.Id;
        }
    }
}
