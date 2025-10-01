using EfCore_Maktab135.Enum;

namespace EfCore_Maktab135.Entities;

public class User : BaseEntity
{
    public int Age { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public UserRole Role { get; set; }

    public List<OrderItem> OrderItems { get; set; }
    public List<Order> Orders { get; set; }
    public UserProfile UserProfile { get; set; }

}
