namespace ReviewApp.Models
{
    public class AccountOwner
    {
        public int AccountId { get; set; }
        public int OwnerId { get; set; }

        public Account Account { get; set; }
    }
}
