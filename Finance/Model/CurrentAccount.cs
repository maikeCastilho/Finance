using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class CurrentAccount : Agency
    {
        protected int Number;
        protected string Titular;
        protected double Balance;
        protected string Password;

        public int number
        {
            get { return Number; }
            set { Number = value; }
        }

        public double balance
        {
            get { return Balance; }
            set { Balance = value; }
        }

        public string titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public string password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= (Balance + amount))
            {
                Balance -= amount;
                return true;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo total");
            }
        }

        public double deposit(double value)
        {
            if (value > 0)
            {
                Balance += value;
                return Balance;
            }
            else
            {
                throw new ArgumentException("Não foi possivel depositar");
            }
        }

        public double getBalance()
        {
            return Balance;
        }  
    }
}
