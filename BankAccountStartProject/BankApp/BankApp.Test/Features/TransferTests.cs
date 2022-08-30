using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features
{
    class TransferTests
    {
        [Test]
        public void CanTransferMoneyIntoAnotherAccount()
        {
            //setup
            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 7;
            var fromAccount = new Account { Id = fromAccountId, Balance = 700 };
            var toAccount = new Account { Id = toAccountId, Balance = 0 };

            myMock.Setup(ar => ar.GetAccountById(fromAccountId)).Returns(fromAccount);
            myMock.Setup(ar => ar.GetAccountById(toAccountId)).Returns(toAccount);

            var transfer = new TransferMoney(myMock.Object, new NotificationService());

            // act 
            transfer.Execute(fromAccountId, toAccountId, 100);

            //assert
            Assert.That(toAccount.Balance, Is.EqualTo(100));
            Assert.That(fromAccount.Balance, Is.EqualTo(600));
        }

        [Test]
        public void CannotPayIntoAnotherAccountWhenFundsNotAvailable()
        {
            //setup
            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 7;
            var fromAccount = new Account { Id = fromAccountId, Balance = 100 };
            var toAccount = new Account { Id = toAccountId, Balance = 0 };

            myMock.Setup(ar => ar.GetAccountById(fromAccountId)).Returns(fromAccount);
            myMock.Setup(ar => ar.GetAccountById(toAccountId)).Returns(toAccount);

            var transfer = new TransferMoney(myMock.Object, new NotificationService());

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, 300));

            //assert
            Assert.Multiple(() =>
            {
                Assert.That(toAccount.Balance, Is.EqualTo(0));
                Assert.That(fromAccount.Balance, Is.EqualTo(100));
            });
        }

        [Test]
        public void CannotPayIntoAnotherAccountAbovePayInLimit()
        {
            //setup
            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 7;
            var fromAccount = new Account { Id = fromAccountId, Balance = 70000 };
            var toAccount = new Account { Id = toAccountId, Balance = 0};

            myMock.Setup(ar => ar.GetAccountById(fromAccountId)).Returns(fromAccount);
            myMock.Setup(ar => ar.GetAccountById(toAccountId)).Returns(toAccount);

            var transfer = new TransferMoney(myMock.Object, new NotificationService());

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, 54000));

            //assert
            Assert.That(toAccount.Balance, Is.EqualTo(0));
            Assert.That(fromAccount.Balance, Is.EqualTo(70000));
        }

        [Test]
        public void IfTransferAmountIsNegative_ThenThrowsException()
        {
            //setup
            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 7;
            var fromAccount = new Account { Id = fromAccountId, Balance = 700 };
            var toAccount = new Account { Id = toAccountId, Balance = 0 };

            myMock.Setup(ar => ar.GetAccountById(fromAccountId)).Returns(fromAccount);
            myMock.Setup(ar => ar.GetAccountById(toAccountId)).Returns(toAccount);

            var transfer = new TransferMoney(myMock.Object, new NotificationService());

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, -150));

            //assert
            Assert.That(toAccount.Balance, Is.EqualTo(0));
            Assert.That(fromAccount.Balance, Is.EqualTo(700));
        }
    }
}
