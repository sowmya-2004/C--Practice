
using System;
using System.Collections.Generic;
namespace hello
{
    public class BankAccount
    {
        private int balance = 1000;
        public void Balance()
        {
            Console.WriteLine(balance);
        }
        public void Deposit(int amt)
        {
            balance = balance + amt;
            Console.WriteLine("amount deposited is " + amt);
        }
        public void withdraw(int amt)
        {
            if (balance >= amt)
            {
                balance = balance - amt;
                Console.WriteLine("balance withdrawn is " + amt);
            }
            else
            {
                Console.Write("insufficient balance");
            }
        }
        //public static void Main(string[] args)
        //{
        //    BankAccount b = new BankAccount();
        //    b.Balance();
        //    b.Deposit(500);
        //    b.Balance();
        //    b.withdraw(200);
        //    b.withdraw(5000);
        //}
    }
}