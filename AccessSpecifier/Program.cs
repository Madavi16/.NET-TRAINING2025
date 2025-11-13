using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccessSpecifier
{
    class Person
    {
        protected string name;
        protected int age;
        protected string location;

        //when we are having the parameterized constructor on the base we also need to pass the parameter in the derived
        //or child constructor using the keyword "base"
        //Eg: class employee (...employee and person constructor paramters...):base(...base constructor parameter....)
        public Person(string name, int age,string location) {
            this.name = name;
            this.age = age;
            this.location = location;

            Console.WriteLine("Person or base class constructor");
            
        }
        public void getPersonDetails()
        {
                Console.WriteLine("Enter the name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter location: ");
                location = Console.ReadLine();
                
           
        }
        protected void DisplayPersonDetails()
        {
            Console.WriteLine("\n========== Personal Information ==========\n");
            Console.WriteLine($"Name: {name}\nAge: {age}\nLocation: {location}");
            Console.WriteLine("\n==========================================\n");
        }
    }
    class Employee:Person
    {
          int empID;
         //string employeeName;
         string employeeDesignation;
         double employeeSalary;

        public Employee( string name,  int age, string location,  int id,  string desg, double salary):base( name, age, location) 
        {
            this.empID=id;
            this.employeeDesignation=desg;
            this.employeeSalary=salary;
            
            Console.WriteLine("Employee or child derived class constructor created");
        }
        public void getEmployeeDetails()
        {

                getPersonDetails();
            
                Console.WriteLine("\nEnter Employee ID: ");
                empID = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Enter Employee Name: ");
                //employeeName = Console.ReadLine();

                Console.WriteLine("Enter Employee Role: ");
                employeeDesignation = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary: ");
                employeeSalary = Convert.ToDouble(Console.ReadLine());

               

        }

        //protected variable can be accessed by private class after inheritance of the class.
        //void DisplayPersonDetails()
        //{
        //    Console.WriteLine("\n========== Personal Information ==========\n");
        //    Console.WriteLine($"Name: {name}\nAge: {age}\nLocation: {location}");
        //    Console.WriteLine("\n==========================================\n");
        //}
        public void DisplayEmployeeDetails()
        { 
            DisplayPersonDetails();
            Console.WriteLine("\n========== Employee Details ==========\n");
            Console.WriteLine($"Employee Id: {empID}\nEmployee Designation: {employeeDesignation}\nEmployee Salary: {employeeSalary}");
            Console.WriteLine("\n======================================\n");

        }
    }
    internal class Program 
    {
        static void Main(string[] args)
        {

            //    Console.WriteLine("\nEnter the number of persons: ");
            //    int count=Convert.ToInt32(Console.ReadLine());

            //    for (
            //        int i = 0; i < count; i++)
            //    {


            Employee emp = new Employee(name:"Mahe",age:23,location:"Bangalore",id:6840,desg:"HR",salary:90000);
            
           // emp.getPersonDetails();
            //
            emp.getEmployeeDetails();
            //emp.DisplayPersonDetails();//child class obj cannot access parent class protected members.


            emp.DisplayEmployeeDetails();
            //}

                Console.ReadLine();
        }
    }
}
