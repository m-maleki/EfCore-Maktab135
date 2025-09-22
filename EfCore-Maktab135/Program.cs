using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Service;
using EfCore_Maktab135.Extensions;
using EfCore_Maktab135.Infrastructure;
using EfCore_Maktab135.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

AppDbContext appDbContext = new AppDbContext();

var result = appDbContext.Orders
    .Include(x=>x.OrderItems)
    .ThenInclude(x=>x.Customer)
    .FirstOrDefault(x => x.Id == 1);

IProductService productService = new ProductService();
IOrderService orderService = new OrderService();

var customerId = 3;

var selectedProducts = new List<ShowProductDto>();
int productId = 0;


var products = productService.GetAll();
do
{
    Console.Clear();
    ConsolePainter.WriteTable(products);

    Console.Write("please select a product id : ");
    productId = int.Parse(Console.ReadLine());

    var selectedProduct = products.FirstOrDefault(x => x.Id == productId);

    if(selectedProduct is null)
        break;

    if (selectedProducts.Any(x => x.Id == productId))
    {
        selectedProducts.First(x => x.Id == productId).Count++;
    }
    else
    {
        selectedProducts.Add(new ShowProductDto()
        {
            Name = selectedProduct.Name,
            CategoryName = selectedProduct.CategoryName,
            Price = selectedProduct.Price,
            Color = selectedProduct.Color,
            Count = 1,
            Id = selectedProduct.Id
        });
    }

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Youre basket :");
    ConsolePainter.WriteTable(selectedProducts, ConsoleColor.DarkGreen);
    Console.ReadKey();
} while (productId >0);

Console.Clear();
Console.WriteLine("Youre basket :");
ConsolePainter.WriteTable(selectedProducts, ConsoleColor.DarkGreen);
var totalPrice = selectedProducts.Sum(x => x.Price);
Console.WriteLine($"Total price == {totalPrice}");
Console.WriteLine($"Complete order ? ");


if (Console.ReadKey().Key == ConsoleKey.Enter)
{
    var orderItems = selectedProducts.Select(x => new OrderItem()
    {
        CustomerId = customerId,
        Count = x.Count,
        Price = x.Price,
        ProductId = x.Id,
    }).ToList();

    var order = new Order()
    {
        TotalPrice = totalPrice,
        OrderItems = orderItems
    };

    var orderId = orderService.Create(order);
}

Console.WriteLine("");