using System;

namespace Moneybox.App.DataAccess
{
    public interface IAccountRepository
    {
        Account GetAccountById(int accountId);

        void Update(Account account);
    }
}
