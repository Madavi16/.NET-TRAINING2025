using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankingSystem
{
    class BankAccount
    {
        public string AccountNumber;
        public string AccountHolder;
        public decimal balance;

        public BankAccount(string accNo, string accHolder, decimal initialBalance)
        {
            AccountNumber = accNo;
            AccountHolder = accHolder;
            this.balance = initialBalance;
        }
        public BankAccount(decimal initialBalance)
        {
            this.balance = initialBalance;
        }

        public static BankAccount operator +(BankAccount a1, BankAccount a2)
        {
            decimal combinedBalance = a1.balance + a2.balance;
            return new BankAccount("\nMerged Account", a1.AccountHolder + "&" + a2.AccountHolder, combinedBalance);
        }

        public static BankAccount operator-(BankAccount acc, decimal amount)
        {
            if(amount>acc.balance)
            {
                Console.WriteLine($"Insufficient Account balance in {acc.AccountNumber}, Transaction Failed!");
                return acc;
            }

            acc.balance -= amount;
            return acc; 
        }

        public static bool operator==(BankAccount a1, BankAccount a2)
        {
            return a1.balance == a2.balance;
        }
        public static bool operator!=(BankAccount a1, BankAccount a2)
        {
            return !(a1 == a2);
        }
        public static bool operator >(BankAccount a1, BankAccount a2)
        {
            return a1.balance > a2.balance;
        }
        public static bool operator<(BankAccount a1, BankAccount a2)
        {
            return a1.balance < a2.balance;
        }

        public override bool Equals(object obj)
        {
            if(obj is BankAccount acc)
            {
                return this.balance == acc.balance;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return balance.GetHashCode();
        }
        public override string ToString()
        {
            return $"\nAccount Number: {AccountNumber}\nAccount Holder: {AccountHolder}\nBalance: {balance}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount acc1 = new BankAccount("AC101", "Ramesh Kumar", 40000);
            BankAccount acc2 = new BankAccount("AC102", "Suresh Nair", 40000);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

            Console.WriteLine("\nMerging account (using +): ");
            BankAccount balance = acc1 + acc2;
            Console.WriteLine($"\nCombine Balance: {balance}");

            Console.WriteLine("\nComparing Balances: ");
            Console.WriteLine($"AC101 < AC102 -> {acc1 < acc2}");
            Console.WriteLine($"AC101 > AC102 -> {acc1 > acc2}");
            Console.WriteLine($"AC101 == AC102 -> {acc1 == acc2}");
            Console.WriteLine($"AC101 != AC102 -> {acc1 != acc2}");
            Console.WriteLine($"Equals Method -> {acc1.Equals(acc2)}");

            Console.WriteLine("\nWithdrawal operation (using -): ");
            acc1 = acc1 - 50000;
            acc2 = acc2 - 2000;

            Console.WriteLine($"New Balance of Ramesh: {acc1}");
            Console.WriteLine($"New Balance of Suresh: {acc2}");

            
            Console.ReadLine();
        }
    }
}
