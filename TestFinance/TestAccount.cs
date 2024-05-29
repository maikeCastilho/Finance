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

            Account account1 = new Account(123, saldoInicial);

            //operation
            account1.deposit(valorDeposito);

            //verify
            Assert.AreEqual(saldoFinal, account1.balance);
        }

        [TestMethod]
        public void WithdrawTest()
        {
            //build
            decimal saldoInicial = 1000;
            decimal valorSaque = 500;
            decimal saldoFinal = 500;
            Account account = new Account(123, saldoInicial);

            //operation
            account.withdraw(valorSaque);

            //verify
            Assert.AreEqual(saldoFinal, account.Balance);
        }

        [TestMethod]
        public void ValorSaqueMaiorSaldo()
        {
            //build
            decimal saldoInicial = 1000;
            decimal valorSaque = 1500;

            //operation
            Account conta1 = new Account(123, saldoInicial);

            //verify
            Assert.ThrowsException<ArgumentException>(() => conta1.withdraw(valorSaque));
        }

    }
}