using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Financeiro.Model
{
    public class Client
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Client(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
