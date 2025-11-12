using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExample
{
    internal class FunctionwithReturnWithArg
    {
        static void Main(string[] args)
        {
            int total = Addition(34, 52);
            Console.WriteLine($"Sum: {total}");
            Console.ReadLine();
        }
        static int Addition(int a,int b)
        {
            int result = a + b;
            return result;
        }
    }
}
