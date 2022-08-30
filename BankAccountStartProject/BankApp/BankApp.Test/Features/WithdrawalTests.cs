using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features
{
    class WithdrawalTests
    {
        [Test]
        public void CanWithdrawMoneyFromAccount()
        {
            // setup
            var mock = new Mock<IAccountRepository>();
            var mockNotificationService = new Mock<INotificationService>();
            var account = new Account { Id = 30, Balance = 1000 };

            mock.Setup(ar => ar.GetAccountById(30)).Returns(account);
            
            var withdraw = new WithdrawMoney(mock.Object, mockNotificationService.Object);

            // act 
            withdraw.Execute(30, 600);

            // assert
            Assert.That(account.Balance, Is.EqualTo(400));
        }

        [Test]
        public void IfAmountIsNegative_ThenThrowsException()
        {
            var repo = new Mock<IAccountRepository>();
            const int accountId = 10;
            var account = new Account { Id = accountId, Balance = 600 };

            repo.Setup(x => x.GetAccountById(accountId)).Returns(account);
            var withdraw = new WithdrawMoney(repo.Object, new Mock<INotificationService>().Object);

            // act & assert
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(accountId, -100));

            //assert
            Assert.That(account.Balance, Is.EqualTo(600)); // balance is unchanged
        }

        [Test]
        public void IfWithdrawingMoreThanBalance_ThenThrowsException()
        {
            var repo = new Mock<IAccountRepository>();

            const int accountId = 10;
            var account = new Account { Id = accountId, Balance = 500 };
            repo.Setup(x => x.GetAccountById(accountId)).Returns(account);
            var withdraw = new WithdrawMoney(repo.Object, new NotificationService());

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(accountId, 900));

            //assert
            Assert.That(account.Balance, Is.EqualTo(500));
        }
    }
}
