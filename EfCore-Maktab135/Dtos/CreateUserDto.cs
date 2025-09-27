using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_Maktab135.Dtos
{
    public class CreateUserDto
    {
        public string username { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
    }
}
