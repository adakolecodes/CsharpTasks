﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneybox.App;
using Moneybox.App.DataAccess;
using NUnit;
using NUnit.Framework;

namespace UnitTestProject1
{
    class DanielsFirstTest
    {
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
    }
}
