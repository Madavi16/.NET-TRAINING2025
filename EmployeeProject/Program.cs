using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();

            Console.WriteLine("Enter the number of employees: ");
            int n=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"\n Enter details for Employee {i+1}: ");
                Console.Write("ID: ");
                int id=Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Department: ");
                string dept=Console.ReadLine();

                Console.Write("Salary: ");
                double salary=Convert.ToDouble(Console.ReadLine());

                Employee emp=new Employee();
                emp.SetDetails(id, name, dept, salary);

                manager.AddEmployee( emp );
            }

            manager.ShowAllEmployee();
            manager.FindHighestSalary();

            Console.ReadLine();
        }
    }
}
