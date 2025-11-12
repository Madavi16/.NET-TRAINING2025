using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class Employee
    {
        private int empID;
        private string empName;
        private string department;
        private double salary;

        public void SetDetails(int id,string name, string dept,double sal)

        {
            this.empID = id;
            this.empName = name;
            this.department = dept;
            this.salary = sal;
        }

        public void DisplayDetail()
        {
            Console.WriteLine($"Employee Id: {empID}\nName: {empName}\nDepartment: {department}\nSalary: {salary}");

        }

        public double GetSalary()
        {
            return salary;
        }

        public string GetName()
        { 
            return empName;
        }
    }
}
