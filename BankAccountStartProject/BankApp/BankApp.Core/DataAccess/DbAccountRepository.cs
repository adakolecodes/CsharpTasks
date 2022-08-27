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
            dbAccount.User.Email = emailAddress;

            using (var dbContext = new Bank2Context())
            {
                dbContext.AccountDbs.Add(dbAccount);
                dbContext.SaveChanges();
            }
            return dbAccount.Id;
        }

        public Account GetAccountById(int accountId)
        {
            using (var dbContext = new Bank2Context())
            {
                var result = dbContext.AccountDbs.SingleOrDefault(x => x.Id == accountId);

                var account = new Account();
                account.Balance = result.Balance;

            }
        }

        public IEnumerable<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
