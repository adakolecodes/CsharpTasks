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
        private Dictionary<int, Account> _accounts;

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

            // Exactly the same as this but above easier to understand and shorter
//            var res = _accounts.TryGetValue(accountId, out var account);
//            if (res == false)
//            {
//                throw new Exception($"Account with id {accountId} was not found");
//            }
//            else
//            {
//                return account;
//            }
        }

        public void Update(Account account)
        {
            // add or update in dictionary
            _accounts[account.Id] = account;
        }
    }
}
