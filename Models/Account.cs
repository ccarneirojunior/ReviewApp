namespace ReviewApp.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<AccountOwner> AccountOwners { get; set; }
        public ICollection<AccountCategory> AccountCategories { get; set; }



    }
}
