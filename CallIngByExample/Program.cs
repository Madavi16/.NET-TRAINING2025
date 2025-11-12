using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallIngByExample
{
    internal class Program
    {
        //Call by Value
        static void Main(string[] args)
        {
            int num1 = 10;
            Console.WriteLine($"Value before calling: {num1}");
            ChangeValue(num1);
            Console.WriteLine($"Value after calling by value: {num1}");
           ChangeRefer(ref num1);
            Console.WriteLine($"Value after calling by reference:{num1}");
            Console.ReadLine();
        }
        static void ChangeValue(int n)
        {
            n = 50;
            Console.WriteLine($"Inside value: {n}");
        }
        static void ChangeRefer(ref int m)
        {
            m = 30;
            Console.WriteLine($"Inside reference: {m}");
        }
    }
}
