using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Adding_Money_Updates_Balance()
        {
            //Arrange
            var account = new Account(1000);

            //Act
            account.AddMoney(200);

            //Assert
            Assert.AreEqual(1200, account.Balance);
        }

        [TestMethod()]
        public void Withdrawing_Money_Updates_Balance()
        {
            //Arrange
            var account = new Account(1000);

            //Act
            account.WithdrawMoney(500);

            //Assert
            Assert.AreEqual(500, account.Balance);
        }

        [TestMethod()]
        public void Transfering_Money_Updates_Balance()
        {
            //Arrange
            var account = new Account(1000);
            var otherAccount = new Account();

            //Act
            account.TransferMoney(otherAccount, 200);

            //Assert
            Assert.AreEqual(800, account.Balance);
            Assert.AreEqual(200, otherAccount.Balance);
        }
    }
}