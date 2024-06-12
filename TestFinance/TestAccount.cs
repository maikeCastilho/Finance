using Finance.Model;
using static System.Net.Mime.MediaTypeNames;

namespace Finance
{
    [TestClass]
     public class TestAccount
    {
        [TestMethod]
        public void DepositTest()
        {
            //build
            decimal saldoInicial = 1000;
            decimal valorDeposito = 1000;
            decimal saldoFinal = 2000;
            Agency agency = new Agency();
            Account account1 = new Account(123, saldoInicial, "maike", "16022247730", 2003, agency);
            Console.WriteLine(account1.Agency.Name);

            //operation
            account1.deposit(valorDeposito);

            //verify
            Assert.AreEqual(saldoFinal, account1.balance);
        }

        [TestMethod]
        public void WithdrawTest()
        {
            //build
            decimal saldoInicial = 1000m;
            decimal valorSaque = 500m;
            decimal saldoFinal = 490m;
            Account account = new Account(123, saldoInicial, "maike", "16022247730", 2003);

            //operation
            account.withdraw(valorSaque);

            //verify
            Assert.AreEqual(saldoFinal, account.Balance);
        }

        [TestMethod]
        public void ValorSaqueMaiorSaldo()
        {
            //build
            decimal saldoInicial = 1000m;
            decimal valorSaque = 2000m;

            //operation
            Account account1 = new Account(123, saldoInicial, "maike", "16022247730", 2003);

            //verify
            Assert.ThrowsException<ArgumentException>(() => account1.withdraw(valorSaque));
        }

    }
}