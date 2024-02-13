using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            BankAccount account = new BankAccount();
            account.AccountNumber = 123456789;
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            account.balance = 200;
            Console.WriteLine("Account Balance: Rs." + account.balance);
            Console.WriteLine("Enter deposit amount:");
            double depoAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Updated Balance: Rs.{account.Deposit(depoAmount)}");
            Console.ReadLine();

        }
    }
}
