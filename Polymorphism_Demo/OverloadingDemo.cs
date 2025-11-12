using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Demo
{
    internal class OverloadingDemo
    {
        public void GetEmployeeInfo(int id)
        {
            Console.WriteLine("Employee id: "+id);
        }

        public void GetEmployeeInfo(string name)
        {
            Console.WriteLine("Employee Name: "+name);
        }

        public void GetEmployeeInfo(int id, string name)
        {
            Console.WriteLine($"Id: {id}\tName: {name}");
        }

        public void GetEmployeeInfo(string name, int id)
        {
            Console.WriteLine($"Name: {name}, Id: {id}");
        }
    }
}
