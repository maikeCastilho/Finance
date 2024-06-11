using Finance.Model;
using System.ComponentModel.DataAnnotations;

namespace Finance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Agency agency1 = new Agency(1002, "SuperAgencia", "2499965065");


            Account account1 = new Account(234235, 1500.00m, "James", "23424547750", 2000, agency1);
            Account account2 = new Account(654321, 2300.00m, "Maike", "16022247730", 2003, agency1);

            Console.WriteLine(account1.Agency.Name);

            account1.Transfer(200, account2);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);


            //Console.WriteLine("R$" + account1.Balance);
            //Console.WriteLine("R$" + account2.Balance);

            //double amount = account1.Balance + account2.Balance;


            //accounts.Add(account1);
            //accounts.Add(account2);

            //double bigBalance = accounts.Max(b => b.balance);

            //Console.WriteLine("Maior Saldo:" + bigBalance.Number);

            //Console.WriteLine("Saldo das duas contas:" + amount);

        }
    }
}