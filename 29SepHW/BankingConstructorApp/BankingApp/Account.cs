using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {
        public string Number { get; set; }
        public string Name { get; set; }

        public double Balance { get; private set; }


        public Account(string number,string name)
        {
            Name = name;
            Number = number;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public string GetReport()
        {
            string msg = Name + " your account no : " + Number + " and it's balance is : " + Balance;
            return msg;
        }

    }
}
