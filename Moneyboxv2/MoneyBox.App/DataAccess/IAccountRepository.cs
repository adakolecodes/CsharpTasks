using System;
using System.Collections.Generic;

namespace Moneybox.App.DataAccess
{
    public interface IAccountRepository
    {
        Account GetAccountById(int accountId);

        void Update(Account account);
    }

    public class AccountRepository : IAccountRepository
    {
        private readonly Dictionary<int, Account> _accounts;
        private int _lastId = 1;

        public AccountRepository()
        {
            _accounts = new Dictionary<int, Account>();
        }

        public Account GetAccountById(int accountId)
        {
            if (!_accounts.ContainsKey(accountId))
            {
                throw new Exception($"Account with id {accountId} was not found");
            }

            return _accounts[accountId];
        }

        public void Update(Account account)
        {
            if (account.Id == 0)
            {
                account.Id = _lastId++;
                account.User.Id = _lastId++;
            }

            // add or update in dictionary
            _accounts[account.Id] = account;
        }
    }
}
