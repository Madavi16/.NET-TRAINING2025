using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExample
{
    internal class FunctionWithoutReturnWithArg
    {
        static void Main(string[] args)
        {
            Addition(10, 20);
        }
        static void Addition(int x, int y)
        {
            int result=x+y;
            Console.WriteLine($"Sum: {result}");
            Console.ReadLine();
        }
    }
}
