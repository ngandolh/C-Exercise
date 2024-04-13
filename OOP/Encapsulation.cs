using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            balance += amount;
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        // Method to display balance
        public void DisplayBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BankAccount account = new BankAccount(1000);
    //        account.DisplayBalance();
    //        account.Deposit(500);
    //        account.DisplayBalance();
    //        account.Withdraw(200);
    //        account.DisplayBalance();
    //    }
    //}
}

