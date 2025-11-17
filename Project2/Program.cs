using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            float avg_score = 234.45f;
            string message = " Hello everyone";

            Console.WriteLine("Num1 value is : "+num1);
            Console.WriteLine("Num2 value is : {0}",num2);

            Console.WriteLine($"Float value : {avg_score} \n Message is : {message}");

            Console.ReadLine();
        }
    }
}
