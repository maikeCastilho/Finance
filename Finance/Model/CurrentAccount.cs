using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(long number, decimal balance, string name, string cpf, int anoNascimento, Agency agency, decimal creditLimit)
            : base(number, balance, name, cpf, anoNascimento, agency)
        {
           
        }

        public decimal getBalance()
        {
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= (Balance + amount))
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo total");
            }
        }


        public void Transfer(decimal amount, Account destination_account)
        {
            if (amount > 0 && amount <= (Balance + amount))
            {
                Withdraw(amount);
                destination_account.deposit(amount);
            }
            else
            {
                throw new ArgumentException("Você não possuí saldo sufiente para essa transação");
            }
        }
    }
}
