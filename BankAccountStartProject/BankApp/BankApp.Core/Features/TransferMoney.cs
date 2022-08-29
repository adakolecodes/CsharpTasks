﻿using BankApp.Core.DataAccess;
using BankApp.Core.Services;
using System;

namespace BankApp.Core.Features
{
    public class TransferMoney
    {
        private IAccountRepository _accountRepository;
        private INotificationService _notificationService;

        public TransferMoney(IAccountRepository accountRepository, INotificationService notificationService)
        {
            _accountRepository = accountRepository;
            _notificationService = notificationService;
        }

        public void Execute(int fromAccountId, int toAccountId, decimal amount)
        {
            var from = _accountRepository.GetAccountById(fromAccountId);
            var to = _accountRepository.GetAccountById(toAccountId);

            // ToDo
            if (from.CanWithdraw(amount))
                to.PayIn(amount);
                from.Withdraw(amount);

            if (from.IsLowBalance())
                _notificationService.NotifyFundsLow(from);

            if (from.FraudulentActivityDectected())
            {
                _notificationService.NotifyFraudlentActivity(from);
            }

            if (to.FraudulentActivityDectected())
            {
                _notificationService.NotifyFraudlentActivity(to);
            }

            _accountRepository.Update(to);
            _accountRepository.Update(from);
        }
    }
}
