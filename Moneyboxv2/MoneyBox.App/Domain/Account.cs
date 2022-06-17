﻿using System;
using Moneybox.App.Domain;

namespace Moneybox.App
{
    public class SavingsAccount: Account
    {
        public int NoOfWithdrawalsThisMonth { get; set; }

        public override bool CanWithdraw(decimal amount)
        {
            if (NoOfWithdrawalsThisMonth > 1)
                return false;

            return base.CanWithdraw(amount);
        }

    }

    public class Account
    {
        public const decimal PayInLimit = 4000m;
        public const decimal LowBalanceThreshold = 500m;
        public const decimal BalanceLimitForWithdraw = 8000m;

        public int Id { get; set; }

        public User User { get; set; }

        public decimal Balance { get; set; }

        public decimal Withdrawn { get; set; }

        public decimal PaidIn { get; set; }

        private void GuardPositive(decimal amount)
        {
            if (amount < 0)
                throw new InvalidOperationException("Amount should be positive");
        }

        public virtual void Withdraw(decimal amount)
        {
            GuardPositive(amount);

            if (!CanWithdraw(amount))
                throw new InvalidOperationException("Insufficient funds to make transfer");

            this.Balance = this.Balance - amount;
            this.Withdrawn = this.Withdrawn - amount;
        }

        public virtual bool CanWithdraw(decimal amount)
        {
            var newBalance = this.Balance - amount;
            return newBalance >= BalanceLimitForWithdraw;
        }

        public bool IsLowBalance()
        {
            return WillBeLowBalanceAfterWithdrawal(0);
        }

        public bool WillBeLowBalanceAfterWithdrawal(decimal amount)
        {
            var newBalance = this.Balance - amount;
            return newBalance < LowBalanceThreshold;
        }
    }
}
