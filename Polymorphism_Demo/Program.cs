using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OverloadingDemo overloading=new OverloadingDemo();
            overloading.GetEmployeeInfo(101);
            overloading.GetEmployeeInfo("Mahe");
            overloading.GetEmployeeInfo(901, "mahe");
            overloading.GetEmployeeInfo("Rishi", 204);
            Console.ReadKey();
        }
    }
}
