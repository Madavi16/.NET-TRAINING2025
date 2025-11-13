using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc=new Calc();

            Console.WriteLine("Enter the first num: ");
            double x=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second num: ");
            double y=Convert.ToDouble(Console.ReadLine());

            //using tuple
            //var result=calc.Calculate(x, y);
            //Console.WriteLine($"\nSum= {result.Sum}");
            //Console.WriteLine($"\nDifference = {result.Difference}");
            //Console.WriteLine($"\nMultiplication = {result.Product}");
            //Console.WriteLine($"\nDivision = {result.Division}");

            //using out keyword
            //calc.Calculate(x, y, out double sum, out double diff, out double prod, out double div);
            //Console.WriteLine($"\nSum: {sum}\nDiff: {diff}\nProduct: {prod}\nDivision:{div}");


            //using struct
            var structResult = calc.CalculateUsingStruct(x, y);
            Console.WriteLine($"\nUsing Struct: ");
            Console.WriteLine($"Sum: {structResult.Sum}");
            Console.WriteLine($"Difference: {structResult.Difference}");
            Console.WriteLine($"Product: {structResult.Product}");
            Console.WriteLine($"Division: {structResult.Division}");


            //using class
            var classResult=calc.CalculateUsingClass(x, y);
            Console.WriteLine($"\nUsing class: ");
            Console.WriteLine($"Sum= {classResult.Sum}");
            Console.WriteLine($"Difference= {classResult.Difference}");
            Console.WriteLine($"Product= {classResult.Product}");
            Console.WriteLine($"Division= {classResult.Division}");

            Console.ReadLine();
        }
    }
}
