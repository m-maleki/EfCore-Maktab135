using System.ComponentModel.DataAnnotations;

namespace EfCore_Maktab135.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public DateTime CreateAt { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int Count { get; set; } // موجودی

    }
}
