using System;
using Moneybox.App.Domain;

namespace Moneybox.App
{
    public class Account
    {
        public const decimal PayInLimit = 4000m;
        public const decimal LowBalanceThreshold = 500m;
        public const decimal BalanceLimitForWithdraw = 0m;

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
            return this.Balance < LowBalanceThreshold;
        }
    }
}
