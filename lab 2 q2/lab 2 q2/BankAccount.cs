using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        public int AccountNumber;
        public double balance;

        public double Deposit(Double depositAmount)
        {
            balance += depositAmount;
            return balance;
        }
    }
}
