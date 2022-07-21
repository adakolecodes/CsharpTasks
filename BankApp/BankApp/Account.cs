using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        private double _balance;

        public Account() { }

        public Account(double balance)
        {
            _balance = balance;
        }

        public double Balance
        {
            get { return _balance; }
        }

        public void AddMoney(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            _balance += amount;
        }

        public void WithdrawMoney(double amount)
        {
            if (amount > _balance || amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            _balance -= amount;
        }

        public void TransferMoney(Account otherAccount, double amount)
        {
            if (otherAccount == null)
            {
                throw new ArgumentNullException(nameof(amount));
            }

            WithdrawMoney(amount);
            otherAccount.AddMoney(amount);
        }
    }
}
