using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_demoApp2
{
    internal class Employee1
    {
        private int empId;
        private string empName;
        private string desig;

        public void AcceptEmployeeDetails(int id, string name, string desig="Jr.Associate")
        {
            this.empId = id;
            this.empName= name;
            this.desig = desig;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {empId}\nEmployee Name: {empName}\nEmployee Role: {desig}");

        }
    }
}
