using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Department
    {
        int departmentID = 101;
        string departmentName, departmentLocation;

        static Department()
        {
            Console.WriteLine("\nStatic Constructer executed\n");
        }
        //class name and constructor name are same
        //default or parameterless constructor
        public Department()
        { 
            departmentID = 1807022;
            departmentName = "Unknown";
            departmentLocation = "Unknown";
            Console.WriteLine("\nDefault constructor called\n---------------------------");
        }

        //parameterized constructor
        public Department(int id, string name, string location)
        {
            this.departmentID = id;
            this.departmentName = name;
            this.departmentLocation= location;
            Console.WriteLine("\nParameterized constructor called \n--------------------------------");
        }

        //copy constructor
        public Department(Department dept)
        {
            Console.WriteLine("\n Copy constructor");
            this.departmentID= dept.departmentID;
            this.departmentName= dept.departmentName;
            this.departmentLocation = dept.departmentLocation;
        }
        public void getDepartmentInfo()
        {
            Console.WriteLine("Enter the department id:");
            departmentID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name of the department: ");
            departmentName = Console.ReadLine();

            Console.WriteLine("Enter the department location: ");
            departmentLocation = Console.ReadLine();
        }

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine("\n===== Department Details =====");
            Console.WriteLine($"Id: {departmentID}");
            Console.WriteLine($"Name: {departmentName}");
            Console.WriteLine($"Location: {departmentLocation}");
        }
        
    }
}
//when u have more than one constructor in a class -> called constructor overloading.
//static constructor always executes first -> we can use it when we want to show any welcome msg while loading an application

//static constructor shouldn't contain ay access specifier
//when we want to initialize our variable with different variables we can use parameterized constructor
//when we want to initialize our variable with some default values we can use parameterless constructor

