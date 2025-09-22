namespace EfCore_Maktab135.Entities;

public class Order
{
    public int Id { get; set; }
    public List<OrderItem> OrderItems { get; set; }

    public int TotalPrice { get; set; }
    public DateTime CreatedAt { get; set; }
}