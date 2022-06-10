using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneybox.App;
using Moneybox.App.DataAccess;
using Moneybox.App.Domain;
using Moneybox.App.Domain.Services;
using Moneybox.App.Features;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new AccountRepository();
            var withdraw = new WithdrawMoney(store, new NotificationService());

            while (true)
            {
                Console.WriteLine("What do you want to do");
                var instruction = Console.ReadLine();
                //How to compare string to ignore case
                if("create".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    CreateAccount(store);
                }
                else if ("withdraw".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    // Implement withdraw
                    // 1. Get from the user an account Id and an amount
                    // 2. Write tests to test the withdrawing functionality

                    Console.WriteLine("Enter your account Id");
                    var accountIdStr = Console.ReadLine();
                    var accountId = Convert.ToInt32(accountIdStr);

                    Console.WriteLine("Enter amount to withdraw");
                    var amount = Console.ReadLine();

                    withdraw.Execute(accountId, Convert.ToDecimal(amount));

                }
            }
        }

        private static void CreateAccount(AccountRepository store)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your email?");
            var email = Console.ReadLine();

            var user = new User
            {
                Name = name,
                Email = email
            };

            var account = new Account
            {
                User = user
            };

            store.Update(account);
        }
    }
}
