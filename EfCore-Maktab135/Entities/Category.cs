namespace EfCore_Maktab135.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }

    public List<Product> Products { get; set; }
}