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
                    Console.WriteLine("What is your name?");
                    var name = Console.ReadLine();
                    Console.WriteLine("What is your email?");
                    var email = Console.ReadLine();

                    var user = new User();
                    user.Name = name;
                    user.Email = email;

                    var account = new Account();

                    account.User = user;
                    account.Id = 1;
                    user.Id = 1;

                    //Make the Id unique
                    //Store the accounts in a list

                }else if ("withdraw".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    // Get 
                    // todo
                    var accountId = 0;
                    var amount = 0m;
                    // todo
                    withdraw.Execute(accountId, amount);
                }
            }
        }
    }
}
