namespace EfCore_Maktab135.Entities
{
    public class OrderItem : BaseEntity
    {
        #region Properties

        public int Count { get; set; }
        public int Price { get; set; }

        #endregion

        #region NavigationProperties

        public Product Product { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Order Order { get; set; }

        #endregion

        #region ForginKey

        public int ProductId { get; set; }
        public int OrderId { get; set; }

        #endregion
    }
}
