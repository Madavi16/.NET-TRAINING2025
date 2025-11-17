using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition();
        }
        static void Addition()
        {
            int num1, num2, sum;
            Console.WriteLine("Enter the frist number: ");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2=Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }
       
        //how can we use multiple main methods in a single project and how do we specify which one should be executed?
        //go to solution explorer -> click on properties -> startup object -> dropdown the list ->
        //-> select the desired class you want to execute -> Build and run

    }
}
