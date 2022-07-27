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
using Moq;
using NUnit.Framework;

namespace UnitTestProject1
{
    /// <summary>
    /// Do not do this. Instead use mocking
    /// </summary>
    public class FakeNotificationService : INotificationService
    {
        public void NotifyApproachingPayInLimit(string emailAddress)
        {
        }

        public void NotifyFundsLow(string emailAddress)
        {
        }
    }

    public class FakeAccountRepository : IAccountRepository
    {
        public Account GetAccountById(int accountId)
        {
            return new Account { Id = accountId, Balance = 600 };
        }

        public void Update(Account account)
        {
        }
    }

    // https://methodpoet.com/unit-testing-with-moq/
    class WithdrawalTests
    {
        [Test]
        public void CanWithdrawMoneyFromAccount()
        {
            // setup
            var mock = new Mock<IAccountRepository>();
            var mockNotificationService = new Mock<INotificationService>();
            var account = new Account { Id = 10, Balance = 1000 };

            // Setup what to return when the method gets called.
            mock.Setup(ar => ar.GetAccountById(30)).Returns(account);
            // Use this when don't care what gets passed through
//            mock.Setup(ar => ar.GetAccountById(It.IsAny<int>())).Returns(account);

            // We pass in the mocked object in the constructor
            var withdraw = new WithdrawMoney(mock.Object, mockNotificationService.Object);

            // act 
            withdraw.Execute(30, 50);

            // assert
            Assert.That(account.Balance, Is.EqualTo(950));
            mock.Verify(x => x.Update(It.IsAny<Account>()), Times.Exactly(1));
            mockNotificationService.Verify(x => x.NotifyFundsLow(It.IsAny<string>()), Times.Never);
        }

        // fix this test 
        //Error was due to the fact that you can't withdraw below the Low Balance Threshold
        [Test]
        public void WhenLowBalance_CanWithdrawMoneyAndLowBalanceNotification()
        {
            // setup
            var mockNotificationSvc = new Mock<INotificationService>();
            var mockAccRepo = new Mock<IAccountRepository>();
            var account = new Account { Id = 10, Balance = 100, User = new User() { Email = "test@a.co.uk" } };

            mockAccRepo.Setup(x => x.GetAccountById(10)).Returns(account);

            var withdraw = new WithdrawMoney(mockAccRepo.Object,mockNotificationSvc.Object);

            // act 
            withdraw.Execute(10, 20);

            // assert
            Assert.That(account.Balance, Is.EqualTo(80));
            mockNotificationSvc.Verify(x => x.NotifyFundsLow("test@a.co.uk"), Times.Exactly(1));
        }

        // Remove 
        [Test]
        public void IfAmountIsNegative_ThenThrowsException()
        {
            var repo = new FakeAccountRepository();
            const int accountId = 10;
            var account = new Account { Id = accountId, Balance = 600 };
            repo.Update(account);
            var withdraw = new WithdrawMoney(repo, new FakeNotificationService());


            // act & assert
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(accountId, -100));

            //assert
            Assert.That(account.Balance, Is.EqualTo(600)); // balance is unchanged
        }

        [Test]
        public void IfWithdrawingMoreThanBalance_ThenThrowsException()
        {
            var repo = new AccountRepository();
            const int accountId = 10;
            var account = new Account { Id = accountId, Balance = 500 };
            repo.Update(account);
            var withdraw = new WithdrawMoney(repo, new NotificationService());

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(accountId, 900));

            //assert
            Assert.That(account.Balance, Is.EqualTo(500)); // balance is unchanged
        }


        [Test]
        public void CanTransferMoneyToAnotherAccount()
        {
            var fakeRepo = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 7;
            var fromAccount = new Account { Id = fromAccountId, Balance = 500 };
            var toAccount = new Account { Id = toAccountId, Balance = 0 };

            fakeRepo.Setup(ar => ar.GetAccountById(fromAccountId)).Returns(fromAccount);
            fakeRepo.Setup(ar => ar.GetAccountById(toAccountId)).Returns(toAccount);
            
            var transfer = new TransferMoney(fakeRepo.Object, new NotificationService());

            // act 
            transfer.Execute(fromAccountId, toAccountId, 100);

            //assert
            Assert.That(toAccount.Balance, Is.EqualTo(100));
            Assert.That(fromAccount.Balance, Is.EqualTo(400));
        }
    }
}
