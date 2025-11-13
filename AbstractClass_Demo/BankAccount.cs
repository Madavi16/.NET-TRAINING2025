using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Demo
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountNumber, double initialBalance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = initialBalance;
        }
        public abstract void CalculateInterest();
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"\nDeposited {amount}. New Balance is {Balance}");
        }
    }
}
