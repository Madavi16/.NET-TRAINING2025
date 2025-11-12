using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_demoApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2;
            //Calculator calculator = new Calculator();
            //Console.WriteLine("Enter your first number: ");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter your second number: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Add: {calculator.Addition(num1, num2)}");
            //Console.WriteLine($"Sub: {calculator.Subtraction(num1, num2)}");
            //calculator.Multiplication(num1, num2);

            Employee1 employee = new Employee1();
            int empId;
            string empName;
            string designation;

            //Console.WriteLine("Enter the employee id, name and designation");
            //empId = Convert.ToInt32(Console.ReadLine());
            //empName = Convert.ToString(Console.ReadLine());
            //designation = Console.ReadLine();
            //employee.AcceptEmployeeDetails(id: empId, name: empName, desig: designation);

            ////employee.AcceptEmployeeDetails(empId, empName, designation);



            //employee.DisplayEmployeeDetails();
            //Console.WriteLine();

            employee.AcceptEmployeeDetails(102, "Madhavi");
            employee.DisplayEmployeeDetails();

            employee.AcceptEmployeeDetails(103, "Jana", "QA");
            employee.DisplayEmployeeDetails();

            Console.ReadLine();
        }
    }
}
