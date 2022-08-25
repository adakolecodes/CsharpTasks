using BankApp.Core.Domain;

namespace BankApp.Core.DataAccess
{
    // Do not write tests for this
    public class InMemoryAccountRepository : IAccountRepository
    {
        private readonly Dictionary<int, Account> _accounts;
        private int _lastId = 1;

        public InMemoryAccountRepository()
        {
            _accounts = new Dictionary<int, Account>();
        }

        public int CreateAccount(string emailAddress)
        {
            var account = new Account();
            account.Id = _lastId++;
            account.Email = emailAddress;
            _accounts.Add(account.Id, account);

            return account.Id;
        }

        public Account GetAccountById(int accountId)
        {
            if (!_accounts.ContainsKey(accountId))
            {
                throw new AccountNotFoundException($"Account with id {accountId} was not found");
            }

            return _accounts[accountId];
        }

        public IEnumerable<Account> GetAll()
        {
            return _accounts.Values.ToList();
        }

        public void Update(Account account)
        {
           _accounts[account.Id] = account;
        }
    }
}
