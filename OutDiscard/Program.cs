using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OutDiscard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //normal out keyword
            //int result;
            //bool success = Int32.TryParse("123", out result);
            //Console.WriteLine($"Success: {success}, Result: {result}");


            //out with discard
            //if(Int32.TryParse("456",out _))
            //{
            //    Console.WriteLine("Conversion successful");
            //}
            //else
            //{
            //    Console.WriteLine("Conversion failed!");
            //}

            //if(Int32.TryParse("456",out int num))
            //{
            //    Console.WriteLine($"Parsed value ={num}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}

            //if (Int32.TryParse("xyz", out _))
            //{
            //    Console.WriteLine("Parsed something");
            //}
            //else
            //{
            //    Console.WriteLine("invalid input ignored");
            //}

            Console.WriteLine("Enter first number: ");
            double num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2=Convert.ToInt32(Console.ReadLine());

            Calculate(num1, num2, out double add, out double diff, out double prod, out double div);
            Console.WriteLine($"Addition: {add}\nSubtraction: {diff}\nProduct: {prod}\nDivision: {div}");

            Calculate(num1, num2, out _, out _, out _, out double divi);
            Console.WriteLine($"\nUsing Discard -> Sum : \tDifference: \tProduct: \tDivision: {divi}");


            int[] marks = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter 5 subject marks: ");
                marks[i]=Convert.ToInt32(Console.ReadLine());
            }

            CalculateMarks(marks, out int total, out double average);
            Console.WriteLine("Displaying marks without discard: ");
            Console.WriteLine($"Total = {total}\nAverage= {average}");

            CalculateMarks(marks, out int tot, out _);
            Console.WriteLine("Displaying mark after discard: ");
            Console.WriteLine($"Total = {tot}\nAverage = ");
            
            Console.ReadLine();

        }
        static void Calculate(double a, double b, out double add,out double diff, out double prod, out double div)
        {
            add = a + b;
            diff = a - b;
            prod = a * b;
            div = (b != 0) ? a / b : double.NaN;
        }

        static void CalculateMarks(int[] marks, out int total, out double average)
        {
            total = 0;
            foreach(int mark in marks)
            {
                total += mark;
            }
            average = total / (double)marks.Length;
        }

    }
}
