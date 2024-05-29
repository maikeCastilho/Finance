using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Financeiro.Model
{
    public class Account
    {
        public long number;
        public decimal balance;

        public long Number
        {
            get { return number; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
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

        public void withdraw(decimal value)
        {
            if (value > 0 && balance > 0)
            {
                balance -= value;
            }
        }
    }
}
