using ReviewApp.Data;
using ReviewApp.Models;

namespace ReviewApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.AccountOwners.Any())
            {
                var AccountOwners = new List<AccountOwner>()
                {
                    new AccountOwner()
                    {
                        Account = new Account()
                        {
                            Name = "Account1",
                            BirthDate = new DateTime(1903,1,1),
                            AccountCategories = new List<AccountCategory>()
                            {
                                new AccountCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Account1",Text = "Pickahu is the best account, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Account1", Text = "Account1 is the best a killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Account1",Text = "Pickchu, Account1, account1", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Pekka",
                            LastName = "Matti",
                            Place = "A Place in Finland",
                            Country = new Country()
                            {
                                Name = "Finland"
                            }
                        }
                    },
                    new AccountOwner()
                    {
                        Account = new Account()
                        {
                            Name = "Account2",
                            BirthDate = new DateTime(1903,1,1),
                            AccountCategories = new List<AccountCategory>()
                            {
                                new AccountCategory { Category = new Category() { Name = "Water"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Account2", Text = "account2 is the best account, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title= "Account2",Text = "Account2 is the best at killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title= "Account2", Text = "account2, account2, account2", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Dis",
                            LastName = "Poils",
                            Place = "Somewhere",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                                    new AccountOwner()
                    {
                        Account = new Account()
                        {
                            Name = "Account3",
                            BirthDate = new DateTime(1903,1,1),
                            AccountCategories = new List<AccountCategory>()
                            {
                                new AccountCategory { Category = new Category() { Name = "Leaf"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Account3",Text = "Account3 is the best account, because it is electric", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Account3",Text = "Account3 is the best at killing rocks", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Account3",Text = "Account3, Account3, Account3", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Mike",
                            LastName = "Whatever",
                            Place = "Somewhere",
                            Country = new Country()
                            {
                                Name = "Abc"
                            }
                        }
                    }
                };
                dataContext.AccountOwners.AddRange(AccountOwners);
                dataContext.SaveChanges();
            }
        }
    }
}