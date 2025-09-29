using System.Security.Principal;

namespace EfCore_Maktab135.Dtos;

public class GetOrderItemDto
{
    public string ProductName { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }

}