namespace EfCore_Maktab135.Entities;

public class Order : BaseEntity
{
    public List<OrderItem> OrderItems { get; set; }

    public User User { get; set; }
    public int UserId { get; set; }

    public int TotalPrice { get; set; }
}