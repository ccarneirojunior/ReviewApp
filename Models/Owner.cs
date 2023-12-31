﻿using ReviewApp.Models;

namespace ReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Place { get; set; }
        public Country Country { get; set; }
        public ICollection<AccountOwner> AccountOwners { get; set; }
    }
}