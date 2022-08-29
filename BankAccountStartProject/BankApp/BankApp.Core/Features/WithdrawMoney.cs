using BankApp.Core.DataAccess;
using BankApp.Core.Services;
using System;

namespace BankApp.Core.Features
{
    public class WithdrawMoney
    {
        private IAccountRepository _accountRepository;
        private INotificationService _notificationService;

        public WithdrawMoney(IAccountRepository accountRepository, INotificationService notificationService)
        {
            this._accountRepository = accountRepository;
            this._notificationService = notificationService;
        }

        public void Execute(int fromAccountId, decimal amount)
        {
            var from = _accountRepository.GetAccountById(fromAccountId);

            // ToDo
            from.Withdraw(amount);

            if (from.IsLowBalance())
                this._notificationService.NotifyFundsLow(from);

            if (from.FraudulentActivityDectected())
            {
                _notificationService.NotifyFraudlentActivity(from);
            }

            this._accountRepository.Update(from);
        }
    }
}
