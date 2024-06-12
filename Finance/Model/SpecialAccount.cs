using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                 
using System.Threading.Tasks;

namespace Finance.Model
{
    public class SpecialAccount : CurrentAccount
    {
        private double CreditLimit { get; set; }

        public Boolean Withdraw(double amount)
        {
            if (amount <= CreditLimit + getBalance())
            {
                return base.Withdraw(amount);
            }
            else
            {
                return false;
            }
        }
    }
}
