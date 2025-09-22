namespace EfCore_Maktab135.Entities
{
    public class OrderItem
    {
        #region Properties

        public int Id { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        #endregion

        #region NavigationProperties

        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Order Order { get; set; }

        #endregion

        #region ForginKey

        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }

        #endregion
    }
}
