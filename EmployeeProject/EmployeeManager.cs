using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }

        public void ShowAllEmployee()
        {
            Console.WriteLine("\n=== Employee Details ===");
            foreach (Employee e in employees)
            {
                e.DisplayDetail();
            }
        }

        public void FindHighestSalary()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employee available");
                return;
            }

            Employee topEmp = employees[0];

            foreach (Employee e in employees)
            {
                if (e.GetSalary() > topEmp.GetSalary())
                {
                    topEmp = e;
                }
            }
            Console.WriteLine($"\n Highest Paid Employee:{topEmp.GetName()} with Salary {topEmp.GetSalary()}");
        }
    
    }
}
