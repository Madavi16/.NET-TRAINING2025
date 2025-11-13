using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Demo
{
    public class SavingsAccount :BankAccount
    {
        public SavingsAccount(string accountNumber, double initialBalance) : base(accountNumber, initialBalance)
        {
            this.Balance = initialBalance;
            this.AccountNumber = accountNumber;
        }
        public override void CalculateInterest()
        {
            double interest = Balance * 0.05;
            Balance += interest;
            Console.WriteLine($"Interest of {interest} added. New Balance is {Balance}");
           
        }
    }
}
