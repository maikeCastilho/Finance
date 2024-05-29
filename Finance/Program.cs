using Finance.Model;

namespace Finance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(123);
            account.deposit(500);

            Console.WriteLine(account.Balance);
        }
    }
}