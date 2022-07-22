using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_Money_Updates_Balance()
        {
            //Arrange
            var account = new Account(1000);

            //Act
            account.AddMoney(500);

            //Assert
            Assert.AreEqual(1500, account.Balance);
        }

        [TestMethod]
        public void Withdrawing_Money_Updates_Balance()
        {
            //Arrange
            var account = new Account(1000);

            //Act
            account.WithdrawMoney(500);

            //Assert
            Assert.AreEqual(500, account.Balance);
        }

        [TestMethod]
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

        [TestMethod]
        public void When_Balance_Is_Low_Return_True()
        {
            //Arrange
            var account = new Account(450);

            //Act
            var result = account.BalanceIsLow();

            //Assert
            Assert.IsTrue(result);
        }
    }
}
