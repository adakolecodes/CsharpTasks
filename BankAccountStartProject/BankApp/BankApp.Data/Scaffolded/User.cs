using System;
using System.Collections.Generic;

namespace BankApp.Data.Scaffolded
{
    public partial class User
    {
        public User()
        {
            AccountDbs = new HashSet<AccountDb>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<AccountDb> AccountDbs { get; set; }
    }
}
