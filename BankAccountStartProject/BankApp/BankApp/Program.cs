// See https://aka.ms/new-console-template for more information
using BankApp.Core.DataAccess;
using BankApp.Core.Features;
using BankApp.Core.Services;


namespace MoneyBox.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var repoService = new InMemoryAccountRepository();
            var notificationService = new NotificationService();


            var withdrawService = new WithdrawMoney(repoService, notificationService);
            var transferService = new TransferMoney(repoService, notificationService);
            var payInService = new PayInMoney(repoService, notificationService);


            while (true)
            {
                Console.WriteLine(@"What do you want to do?
- create
- payin
- withdraw
- transfer
- balance
- notifications");
                var instruction = Console.ReadLine();
                if (instruction == "quit")
                {
                    break;
                }
                else if ("create".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    CreateAccount(repoService);
                }
                else if ("payin".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    PayIn(payInService);
                }
                else if ("withdraw".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    Withraw(withdrawService);
                }
                else if ("transfer".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    Transfer(transferService);
                }
                else if ("balance".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    Balance(repoService);
                }
                else if ("notifications".Equals(instruction, StringComparison.CurrentCultureIgnoreCase))
                {
                    Notifications(notificationService);
                }
            }
        }



        static void CreateAccount(IAccountRepository repo)
        {
            try
            {
                Console.WriteLine("What is your email?");
                var email = Console.ReadLine();

                var accountId = repo.CreateAccount(email);

                Console.WriteLine("Account has been created. Id is: " + accountId);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static void PayIn(PayInMoney payIn)
        {
            try
            {
                Console.WriteLine("Enter your account Id");
                var accountIdStr = Console.ReadLine();
                var accountId = Convert.ToInt32(accountIdStr);

                Console.WriteLine("Enter amount to pay in");
                var amountStr = Console.ReadLine();
                var amount = Convert.ToDecimal(amountStr);

                payIn.Execute(accountId, amount);
                Console.WriteLine("Payment Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static void Withraw(WithdrawMoney withdraw)
        {
            try
            {
                Console.WriteLine("Enter your account Id");
                var accountIdStr = Console.ReadLine();
                var accountId = Convert.ToInt32(accountIdStr);

                Console.WriteLine("Enter amount to withdraw");
                var amountStr = Console.ReadLine();
                var amount = Convert.ToDecimal(amountStr);

                withdraw.Execute(accountId, amount);
                Console.WriteLine("Withdrawal successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static void Transfer(TransferMoney transfer)
        {
            try
            {
                Console.WriteLine("Enter your account Id");
                var fromAccountIdStr = Console.ReadLine();
                var fromAccountId = Convert.ToInt32(fromAccountIdStr);
                Console.WriteLine("Enter other account Id");
                var toAccountIdStr = Console.ReadLine();
                var toAccountId = Convert.ToInt32(toAccountIdStr);

                Console.WriteLine("Enter amount to transfer");
                var amountStr = Console.ReadLine();
                var amount = Convert.ToDecimal(amountStr);

                transfer.Execute(fromAccountId, toAccountId, amount);
                Console.WriteLine("Transfer successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private static void Balance(IAccountRepository repo)
        {
            try
            {
                Console.WriteLine("Enter your account Id");
                var accountIdStr = Console.ReadLine();
                var accountId = Convert.ToInt32(accountIdStr);

                var account = repo.GetAccountById(accountId);
                Console.WriteLine($"Your balance is: {account.Balance}");
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine("Your account has not been found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private static void Notifications(INotificationService notify)
        {
            try
            {
                var notifications = notify.GetAllNotifications();
                Console.WriteLine($"Notifications:");
                foreach (var notification in notifications)
                {
                    Console.WriteLine($"> {notification.Message}");
                }
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine("Your account has not been found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
        }
    }
}