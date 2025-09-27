namespace EfCore_Maktab135.Entities
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}
