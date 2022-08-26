using BankApp.Core.DataAccess;
using BankApp.Core.Services;
using System;

namespace BankApp.Core.Features
{
    public class WithdrawMoney
    {
        private IAccountRepository accountRepository;
        private INotificationService notificationService;

        public WithdrawMoney(IAccountRepository accountRepository, INotificationService notificationService)
        {
            this.accountRepository = accountRepository;
            this.notificationService = notificationService;
        }

        public void Execute(int fromAccountId, decimal amount)
        {
            var from = accountRepository.GetAccountById(fromAccountId);

            // ToDo
            from.Withdraw(amount);

            if (from.IsLowBalance())
                this.notificationService.NotifyFundsLow(from);

            this.accountRepository.Update(from);
        }
    }
}
