using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_Calculator
{
    internal class Program
    {
        class Interest
        {
            public double CalculateInterest(double principle, double rate)
            {
                double time = 1;
                double SI = (principle * rate * time) / 100;
                return SI;
            }
            public double CalculateInterest(double principle, double rate, double time)
            {
                double SI = (principle * rate * time) / 100;
                return SI;
            }
            public double CalculateInterest(double principle, double rate, double time,int n )
            {
                double amount= principle*Math.Pow((1+(rate/(n*100))),n*time);
                double CI = amount - principle;
                return CI;
            }
        }
        static void Main(string[] args)
        {
            Interest interest = new Interest();
            Console.WriteLine("Enter principle: ");
            double principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rate of interest: ");
            double rate=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter time period: ");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number of CI: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n===== Interest Calculator =====\n");

            Console.WriteLine("\n----- Simple Interest : Default for 1 year -----\n");
            double si1 = interest.CalculateInterest(principle, rate);
            Console.WriteLine($"Simple Interest for one year: {si1}");
            Console.WriteLine("\nSimple Interest (Custom Time): ");
            double si2 = interest.CalculateInterest(principle,rate,time);
            Console.WriteLine($"Simple Interest for {time} years: {si2}");
            Console.WriteLine("\nCompount Interest: ");
            double ci = interest.CalculateInterest(principle, rate, time, n);
            Console.WriteLine($"Compound Interest for {time} years: {ci:F2}");
            Console.ReadLine();
        }
    }
}
