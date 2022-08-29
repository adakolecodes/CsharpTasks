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
                account.Email = result.Email;
                account.Balance = result.Balance;
                account.Withdrawn = result.Withdrawn;
                account.PaidIn = result.PaidIn;
                
                return account;
            }
        }

        public IEnumerable<Account> GetAll()
        {
            using (var dbContext = new BankContext())
            {
                //transform the db object into your domain object
                return dbContext.AccountDbs.Select(x => new Account()
                {
                    Email = x.Email,
                    Balance = x.Balance,
                    Withdrawn = x.Withdrawn,
                    PaidIn = x.PaidIn
                }).ToList();
            }
        }

        public void Update(Account account)
        {
            using (var dbContext = new BankContext())
            {
                var result = dbContext.AccountDbs.SingleOrDefault(x => x.Id == account.Id);

                result.PaidIn = account.PaidIn;
                result.Withdrawn = account.Withdrawn;
                result.Balance = account.Balance;

                dbContext.SaveChanges();
            }
        }
    }
}
