using NUnit.Framework;
using Bank;

namespace TestProject1
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Adding_Money_Updates_Balance()
        {
            //Arrange
            var account = new Account(1000);

            //Act
            account.AddMoney(-20);

            //Assert
            Assert.AreEqual(1500, account.Balance);
        }
    }
}