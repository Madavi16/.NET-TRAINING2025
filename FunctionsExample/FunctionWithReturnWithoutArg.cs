using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExample
{
    internal class FunctionWithReturnWithoutArg
    {
        static void Main(string[] args)
        {
            int total = Addition();
            Console.WriteLine($"Sum: {total}");
            Console.ReadLine();
        }
        static int Addition()
        {
            int num1, num2;
            Console.WriteLine("Enter the first number: ");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2=Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            return result;
        }
    }
}
