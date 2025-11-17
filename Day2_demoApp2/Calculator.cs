using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_demoApp2
{
    internal class Calculator
    {
        public int Addition(int a,int b)
        {
            int sum = a + b;
            int avg = sum / 2 ;
            return sum;
        }
        public int Subtraction(int a,int b)
        {
            int diff=a - b;
            return diff;
        }
        public void Multiplication(int a, int b)
        {
            Console.WriteLine($"Mult: {a * b}");
        }
        
    }
}
