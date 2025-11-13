using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Demo
{
   public class CurrentAccount:BankAccount
    {
        public CurrentAccount(string accountNumber, double initialBalance ) : base(accountNumber, initialBalance)
        {
            //this.AccountNumber= accountNumber;
            //this.initialBalance = initialBalance;
        }

        public override void CalculateInterest()
        {
            Console.WriteLine("\nCurrent accounts do not earn interest.");
        }


    }
}
