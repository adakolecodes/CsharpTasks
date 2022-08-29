using BankApp.Core.Domain;
using BankApp.Data.Scaffolded;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Core.DataAccess
{
    public class AccountFactory
    {
        public static Account ToAccount(AccountDb result)
        {
            var account = new Account();
            account.Id = result.Id;
            account.Email = result.Email;
            account.Balance = result.Balance;
            account.Withdrawn = result.Withdrawn;
            account.PaidIn = result.PaidIn;

            return account;
        }
    }
}
