using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class Agency
    {
        private List<CurrentAccount> contas;

        public Agency()
        {
            contas = new List<CurrentAccount>();
        }

        public void InserirConta(CurrentAccount conta)
        {
            contas.Add(conta);
        }

        public double CalculateTotal()
        {
            double total = 0; 
            foreach (var conta in contas)
            {
                total += conta.balance;
            }
            return total;
        }
    }
}
