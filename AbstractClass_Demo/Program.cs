using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your account numner: ");

            string accountNumber=Console.ReadLine();

            Console.WriteLine("Enter your intitial balance: ");

            double initialBalance=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter amount to be deposited: ");
            double amount =Convert.ToDouble(Console.ReadLine());

            SavingsAccount mySavings = new SavingsAccount(accountNumber,initialBalance);
            mySavings.Deposit(initialBalance);
            mySavings.CalculateInterest();

            CurrentAccount currentacc = new CurrentAccount(accountNumber,initialBalance);
            currentacc.Deposit(amount);
            currentacc.CalculateInterest();

            PersonDetails personDetails = new PersonDetails();
            personDetails.GetPersonDetails();

            Console.ReadLine();
        }
    }
}
