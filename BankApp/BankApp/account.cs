using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class account
    {
        public string name;
        public string number;
        public double balance;

        public double  Deposite(double amount)
        {
            return (balance += amount);
        }

        public double Withdraw(double amount)
        {
            return (balance -= amount);
        }


    }
}
