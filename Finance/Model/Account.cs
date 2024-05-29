using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class Account
    {
        public long number;
        public decimal balance;

        public long Number
        {
            get { return number; }
            private set { number = value; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public Account(long number)
        {
            this.number = number;
        }

        public Account(long number, decimal balance)
        {
            this.number = number;
            this.balance = balance;
        }

        public void deposit(decimal value)
        {
            if (value > 0)
            {
                balance += value;
            }
        }


        public decimal withdraw(decimal value)
        {
            if (balance - value >= 0)
            {
                balance -= value;
                return balance;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
        }
    }
}
