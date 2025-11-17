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
            customer.GetProductInfo();
            customer.GetReview();
            Console.WriteLine("\n=========Product Details and Customer Reviews=========\n");
            customer.DisplayProductInfo();
            customer.DisplayReview();
            Console.ReadKey();
        }
    }
}
