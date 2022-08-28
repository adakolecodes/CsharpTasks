using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankApp.Core.Domain;
using BankApp.Data.Scaffolded;

namespace BankApp.Core.DataAccess
{
    public class DbAccountRepository : IAccountRepository
    {
        public int CreateAccount(string emailAddress)
        {
            var dbAccount = new AccountDb();
            dbAccount.Email = emailAddress;

            using (var dbContext = new BankContext())
            {
                dbContext.AccountDbs.Add(dbAccount);
                dbContext.SaveChanges();
            }
            return dbAccount.Id;
        }

        public Account GetAccountById(int accountId)
        {
            using (var dbContext = new BankContext())
            {
                var result = dbContext.AccountDbs.SingleOrDefault(x => x.Id == accountId);

                var account = new Account();
                account.Balance = result.Balance;
                account.Withdrawn = result.Withdrawn;
                account.PaidIn = result.PaidIn;

            }

            return null;
        }

        public IEnumerable<Account> GetAll()
        {
            using (var dbContext = new BankContext())
            {
                var allAccounts = dbContext.AccountDbs.Select(x => x).ToList();
                //return allAccounts;
            }
        }

        public void Update(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
