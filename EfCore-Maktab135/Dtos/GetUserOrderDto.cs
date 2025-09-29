namespace EfCore_Maktab135.Dtos;

public class GetUserOrderDto
{
    public int Id { get; set; }
    public List<GetOrderItemDto> OrderItems { get; set; }
    public DateTime CreateAt { get; set; }
    public int TotalPrice { get; set; }

}