using System;

namespace lab_2_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            BankAccount account = new BankAccount(accountNumber);

            Console.WriteLine("Enter the amount to be deposited: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            account.Deposit(depositAmount);

            Console.WriteLine("Updated Balance: " + account.GetBalance());
            Console.ReadLine();
        }
    }

    class BankAccount
    {
        private int accountNumber;
        private double balance;

        public BankAccount(int accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0; 
        }

        public void Deposit(double amount)
        {
            balance += amount; 
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
