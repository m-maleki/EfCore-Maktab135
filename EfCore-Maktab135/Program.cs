using EfCore_Maktab135.Dtos;
using EfCore_Maktab135.Entities;
using EfCore_Maktab135.Service;
using EfCore_Maktab135.Extensions;
using EfCore_Maktab135.Interfaces.Services;
using EfCore_Maktab135.Enum;
using EfCore_Maktab135.Interfaces.Repositories;

IProductService productService = new ProductService();
IOrderService orderService = new OrderService();
IUserService userService = new UserService();
ICategoryService categoryService = new CategoryService();




AuthenticationMenu();

void AuthenticationMenu()
{
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Register");
    Console.WriteLine("3. Exit");
    while (true)
    {
        try
        {
            int loginItem = int.Parse(Console.ReadLine()!);

            switch (loginItem)
            {
                case 1:
                    Console.Write("UserName : ");
                    var username = Console.ReadLine();

                    Console.Write("Password : ");
                    var password = Console.ReadLine();

                    var login = userService.Login(username, password);

                    if (!login)
                    {
                        Console.WriteLine("username of password is not valid");
                    }
                    else
                    {
                        var loginUserRole = userService.GetRole(username);

                        if (loginUserRole == UserRole.User)
                        {
                            MemberMenu();
                        }
                        else if (loginUserRole == UserRole.Admin)
                        {
                            AdminMenu();
                        }
                    }
                    break;

                case 2:

                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
    
}



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

    if (selectedProduct is null)
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
} while (productId > 0);

Console.Clear();
Console.WriteLine("Your basket :");
ConsolePainter.WriteTable(selectedProducts, ConsoleColor.DarkGreen);
var totalPrice = selectedProducts.Sum(x => x.Price);
Console.WriteLine($"Total price == {totalPrice}");
Console.WriteLine($"Complete order ? ");


if (Console.ReadKey().Key == ConsoleKey.Enter)
{
    var orderItems = selectedProducts.Select(x => new OrderItem()
    {
        UserId = customerId,
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



void MemberMenu()
{
    Console.Clear();
    Console.WriteLine("1. Add a new Product");
    Console.WriteLine("2. Watch the basket");
    Console.WriteLine("3. Settings");
    Console.Write("\nPlease Enter an option: ");


    while (true)
    {
        try
        {
            var selectedOption = int.Parse(Console.ReadLine()!);
            switch (selectedOption)
            {

                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}
void AdminMenu()
{
    Console.Clear();
    Console.WriteLine("1.Manage Categories");
    Console.WriteLine("2.Manage Users");
    Console.WriteLine("3.Manage Orders");

    int selectItem = int.Parse(Console.ReadLine()!);

    switch(selectItem)
    {
        case 1:
            ManageCategoriesMenu();
            break;
        case 2:
            ManageUsersMenu();
            break;
        case 3:
            ManageOrdersMenu();
            break;
    }
}

void ManageCategoriesMenu()
{
    Console.Clear();
    var categories = categoryService.GetAll();

    Console.WriteLine("1. Category List");
    Console.WriteLine("2. Add");
    Console.WriteLine("3. Update");
    Console.WriteLine("4. Delete");

    while (true)
    {
        try
        {
            var selectedOption = int.Parse(Console.ReadLine()!);
            switch (selectedOption)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }
        }
        catch (Exception e)
        {
            ConsolePainter.RedMessage(e.Message);
            Console.ReadKey();
        }
    }
}

void ManageOrdersMenu()
{
    Console.Clear();
    Console.WriteLine("1. Order List");
    Console.WriteLine("2. Filter Orders based on price");
    Console.WriteLine("3. Update");
    Console.WriteLine("4. Delete");

    while (true)
    {
        try
        {
            var selectedOption = int.Parse(Console.ReadLine()!);
            switch (selectedOption)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}

void ManageUsersMenu()
{
    Console.Clear();
    Console.WriteLine("1. User List");
    Console.WriteLine("2. Add");
    Console.WriteLine("3. Activate");
    Console.WriteLine("4. DeActivate");

    while (true)
    {
        try
        {
            var selectedOption = int.Parse(Console.ReadLine()!);
            switch (selectedOption)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}