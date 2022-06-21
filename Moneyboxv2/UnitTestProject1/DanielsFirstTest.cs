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
using NUnit;
using NUnit.Framework;

namespace UnitTestProject1
{
    class DanielsFirstTest
    {
        [Test] 
        public void WhenAccountIdIsNotSet_TheStoreSetsIt()
        {
            // setup
            var repo = new AccountRepository();
            var account = new Account { User = new User()};

            // Act
            repo.Update(account);

            // Assert
            Assert.That(repo.GetAccountById(1), Is.EqualTo(account));
        }

        [Test]
        public void CanSaveAnAccountInTheRepo()
        {
            // setup
            var repo = new AccountRepository();
            var account = new Account {Id = 10, Balance = 100};

            // Act
            repo.Update(account);

            // Assert
            Assert.That(repo.GetAccountById(10), Is.EqualTo(account));
        }

        [Test]
        public void WhenAccountDoesNotExist_CannotFetchItFromTheRepo()
        {
            // setup
            var repo = new AccountRepository();

            // Act & Assert
            Assert.Throws<Exception>(() => repo.GetAccountById(0));
        }


        [Test]
        public void CanWithdrawMoneyFromAccount()
        {
            // setup
            var repo = new AccountRepository();
            var account = new Account { Id = 10, Balance = 1000 };
            repo.Update(account);
            var withdraw = new WithdrawMoney(repo, new NotificationService());

            // act 
            withdraw.Execute(10, 50);

            // assert
            Assert.That(account.Balance, Is.EqualTo(950));
        }

        // fix this test
        [Test]
        public void CanWithdrawMoneyFromAccount2()
        {
            // setup
            var repo = new AccountRepository();
            var account = new Account { Id = 10, Balance = 100 };
            repo.Update(account);
            var withdraw = new WithdrawMoney(repo, new NotificationService());

            // act 
            withdraw.Execute(10, 20);

            // assert
            Assert.That(account.Balance, Is.EqualTo(80));
        }

        [Test]
        public void IfAmountIsNegative_ThenThrowsException()
        {
            var repo = new AccountRepository();
            const int accountId = 10;
            var account = new Account { Id = accountId, Balance = 600 };
            repo.Update(account);
            var withdraw = new WithdrawMoney(repo, new NotificationService());


            // act & assert
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(accountId, -100));

            //assert
            Assert.That(account.Balance, Is.EqualTo(600)); // balance is unchanged
        }

        [Test]
        public void LambdaTest()
        {
            // lamda expression

            var list = new List<int>(){10,20, 30, 40};
            Func<int, int> sq = x => x * x;

            var nwList = new List<int>();
            foreach (var item in list)
            {
                var it = sq(item);
                nwList.Add(it);
            }

            list.ForEach(x => Console.WriteLine(x));
        }

        public int Square(int x)
        {
            return x * x;
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
    }
}
