using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDiscard
{
    internal class StaticNonStatic
    {
        static void Main(string[] args)
        {
            Calculator.Greet();

            Calculator calc=new Calculator();
            Console.WriteLine($"Sum: { calc.Add(89, 67)}");
            calc.Sub(89, 56);
            Console.ReadLine();
        }
    }
    class Calculator
    {
        //static method
        public static void Greet()
        {
            Console.WriteLine("Welcome to Static method");
        }

        //non-static or instance method
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public void Sub(int a, int b)
        {
            int diff = a - b;
            Console.WriteLine($"Difference: {diff}");
        }
    }
}
