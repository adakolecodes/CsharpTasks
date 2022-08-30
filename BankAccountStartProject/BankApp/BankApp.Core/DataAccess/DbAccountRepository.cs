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
            //Create a new object of AccountDb class
            var dbAccount = new AccountDb()
            {
                Email = emailAddress
            };

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

                //This
                //Create an object of Account class, put in the result from query and return the object
                var account = new Account()
                {
                    Id = result.Id,
                    Email = result.Email,
                    Balance = result.Balance,
                    Withdrawn = result.Withdrawn,
                    PaidIn = result.PaidIn
                };

                //OR this
                //var account = AccountFactory.ToAccount(result);

                return account;
            }
        }

        public IEnumerable<Account> GetAll()
        {
            using (var dbContext = new BankContext())
            {
                //This - transform the db object into your domain object
                return dbContext.AccountDbs.Select(x => new Account()
                {
                    Id = x.Id,
                    Email = x.Email,
                    Balance = x.Balance,
                    Withdrawn = x.Withdrawn,
                    PaidIn = x.PaidIn
                }).ToList();

                //OR This
                //return dbContext.AccountDbs.Select(x => AccountFactory.ToAccount(x)).ToList();
            }
        }

        public void Update(Account account)
        {
            using (var dbContext = new BankContext())
            {
                var result = dbContext.AccountDbs.SingleOrDefault(x => x.Id == account.Id);

                if(result == null)
                {
                    throw new Exception($"Account with id {account.Id} not found");
                }

                result.PaidIn = account.PaidIn;
                result.Withdrawn = account.Withdrawn;
                result.Balance = account.Balance;

                dbContext.SaveChanges();
            }
        }
    }
}
