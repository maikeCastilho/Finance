using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class Account
    {
        private long number;
        protected double balance;
        public Client Client {  get; set; }
        public Agency Agency { get; set; }

        public long Number
        {
            get { return number; }
            private set { number = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account(long number, double balance, string name, string cpf, int anoNascimento, Agency agency)
        {
            if (balance < 10.0)
            {
                throw new ArgumentException("O valor mínimo para abrir uma conta é de $10,00");
            }

            this.number = number;
            this.balance = balance;
            Client = new Client(name, cpf, anoNascimento);
            Agency = agency;
        }

        public void deposit(double value)
        {
            if (value > 0)
            {
                balance += value;
            }
        }

        public void Withdraw(double value)
        {
            const double tax = 10.0;

            if (balance - value >= 0)
            {
                balance -= tax;
                balance -= value;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo");
            }
        }

        public void Transfer(double value, Account destination_account) 
        {

            if (value > 0)
            {
                Withdraw(value);
                destination_account.deposit(value);
            }
        }
    }
}
