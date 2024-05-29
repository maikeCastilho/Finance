using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Model
{
    public class Agency
    {
        private int _number;
        private string _name, _telephone;

        public Agency(int number, string name, string telephone)
        {
            _number = number;
            _name = name;
            _telephone = telephone;

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
