using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day6_IndexerDemo
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
    }
    internal class EmployeeList_IndexerDemo
    {
       
            List<Employee> employees = new List<Employee>()
            { new Employee() { EmployeeId = 1, EmployeeName = "Jana", Gender = "Male" },
                new Employee() { EmployeeId = 2, EmployeeName = "Mahe", Gender = "Female" },
                new Employee() { EmployeeId = 3 , EmployeeName = "Chiru", Gender = "Male" }
            };


        public string this[int empid]
        {
            get
            {
                return employees.FirstOrDefault(e => e.EmployeeId == empid)?.EmployeeName;

            }

            set
            {
                employees.FirstOrDefault(e => e.EmployeeId == empid).EmployeeName = value;
            }
        }
        public string this[String name]
        {
            get
            {
                return employees.FirstOrDefault(e => e.EmployeeName==name)?.Gender;

            }
            set
            {
                employees.FirstOrDefault(e => e.EmployeeName==name).Gender = value;
            }
        }
    }
}
