using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class Client
    {
        private string name;
        private string cpf;
        private int anoNascimento;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public int AnoNascimento
        {
            get { return anoNascimento; }
            set {anoNascimento = value; }
        }

        public Client(string name, string cpf, int anoNascimento)
        {
            if (anoNascimento > 2006)
            {
                throw new ArgumentException("O cliente deve ser maior de 18");
            }
            else if (cpf.Length < 11)
            {
                throw new ArgumentException("Cpf inválido");
            }
            else
            {
                this.name = name;
                this.cpf = cpf;
                this.anoNascimento = anoNascimento;
            }
        }

    

    }
}
