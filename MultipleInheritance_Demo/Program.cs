using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer();
            Product ob = customer;
            Review ob1 = customer;
            ob.GetProductInfo();
            ob1.GetReview();
            Console.WriteLine("\n=========Product Details and Customer Reviews=========\n");
            ob.DisplayProductInfo();
            ob1.DisplayReview();
            Console.ReadKey();
        }
    }
}
