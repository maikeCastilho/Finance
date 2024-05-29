using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class Agencia
    {
        private int _number;
        private string _name, _telephone;

        public Agencia(int number)
        {
            _number = number;
        }

        public int Number
        {
            get { return _number; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
    }
}
