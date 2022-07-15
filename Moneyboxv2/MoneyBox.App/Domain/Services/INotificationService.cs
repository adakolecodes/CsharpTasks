using System;
using Moneybox.App.DataAccess;

namespace Moneybox.App.Domain.Services
{
    public interface INotificationService
    {
        void NotifyApproachingPayInLimit(string emailAddress);

        void NotifyFundsLow(string emailAddress);
    }


    public class NotificationService : INotificationService
    {
        public void NotifyApproachingPayInLimit(string emailAddress)
        {
            throw new System.NotImplementedException();
        }

        public void NotifyFundsLow(string emailAddress)
        {
            Console.WriteLine($"{emailAddress} has low balance. Please top up your balance soon.");
        }
    }
}
