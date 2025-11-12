using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day7
{
    static class MathHelper
    {
        public static double PI = 3.14159;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return (b != 0) ? (a / b) : throw new DivideByZeroException("Division by zero is not possible");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers: ");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
                int result = MathHelper.Add(a,b);
                Console.WriteLine($"Addition: {result}");
                result=MathHelper.Sub(a,b);
                Console.WriteLine($"Subtraction: {result}");
                result=MathHelper.Multiply(a,b);
                Console.WriteLine($"Multiplication: {result}");
                result=MathHelper.Division(a,b);
                Console.WriteLine($"Division: {result}");
                Console.ReadLine();
        }
    }
}
