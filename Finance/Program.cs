using Finance.Model;
using System.ComponentModel.DataAnnotations;

namespace Finance
{
    public class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount ca = new CurrentAccount();
            SpecialAccount sa = new SpecialAccount();

            Agency ag = new Agency();
            ag.InserirConta(ca);
            ag.InserirConta(sa);

            ca.deposit(500.0);
            ca.deposit(200.0);

            sa.deposit(1800.40);

            ca.Withdraw(100.0);
            sa.Withdraw(100.0);

            double total = ag.CalculateTotal();

            Console.WriteLine(total.ToString());
        }
    }
}