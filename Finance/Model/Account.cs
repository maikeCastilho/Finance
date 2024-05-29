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
        public long number;
        public decimal balance;

        public Client Client {  get; set; }
        public Agency Agency { get; set; }


        public long Number
        {
            get { return number; }
            private set { number = value; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public Account(long number, decimal balance, string name, string cpf, int anoNascimento, Agency agency)
        {
            if (balance < 10.0m)
            {
                throw new ArgumentException("O valor mínimo para abrir uma conta é de $10,00");
            }

            this.number = number;
            this.balance = balance;
            Client = new Client(name, cpf, anoNascimento);
            Agency = agency;
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
            const decimal tax = 10.0m;

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

        public void Transfer(decimal value, Account destination_account) 
        {

            if (value > 0)
            {
                withdraw(value);
                destination_account.deposit(value);
            }
        }

        public string GetAccountDetails()
        {
            return "";
        }
    }
}
