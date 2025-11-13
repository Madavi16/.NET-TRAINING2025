using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypesProject
{
    public struct CalcResultStruct
    {
        public double Sum;
        public double Difference;
        public double Product;
        public double Division;
    }

    public class CalcResultClass
    {
        public double Sum;
        public double Difference;
        public double Product;
        public double Division;
    }

    internal class Calc
    {
        //Tuple
        //public (double Sum, double Difference, double Product, double Division) Calculate(double a, double b)
        //{
        //    double sum = a + b;
        //    double diff = a - b;
        //    double prod = a * b;
        //    double div = (b != 0) ? a / b : double.NaN;

        //    return (sum, diff, prod, div);

        //}

        //Out keyword
        //public void Calculate(double a, double b,out double sum,out double diff,out double prod, out double div)
        //{
        //     sum = a + b;
        //     diff = a - b;
        //     prod = a * b;
        //     div = (b != 0) ? a / b : double.NaN;
        //}


        //using struct
       //public CalcResultStruct CalculateUsingStruct(double a, double b)
       // {
       //     CalcResultStruct result;
       //     result.Sum = a + b;
       //     result.Difference = a - b;
       //     result.Product = a * b;
       //     result.Division = (b != 0) ? a / b : double.NaN;

       //     return result;

       // }

       // //using class
       // public CalcResultClass CalculateUsingClass(double a, double b)
       // {
       //     CalcResultClass result= new CalcResultClass();
       //     result.Sum = a + b;
       //     result.Difference = a - b;
       //     result.Product = a * b;
       //     result.Division = (b!=0)?a/b: double.NaN;

       //     return result;

       // }

        //using list
        public struct CalcResult 
        {
            public double A;
            public double B;


        }

        public CalcResult CalculateUsingClass(double a, double b)
        {
            CalcResult result = new CalcResultClass();
            result.Sum = a + b;
            result.Difference = a - b;
            result.Product = a * b;
            result.Division = (b != 0) ? a / b : double.NaN;

            return result;

        }
        public void DisplayAll(List<CalcResult> results)
        {
            Console.WriteLine("\n=== Calculation Details ===");
            foreach(var r in results)
            {
                Console.WriteLine($"Sum = {r.Sum}");
            }

        }
    }
    
}
