using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Properties
{
    class Student
    {
        private int age;
        private string name;
        private double salary=45000;
        private string password = "Rishi@123";

        public int Age
        {
            get {
                //if (age <= 0 || age > 120) Console.WriteLine("Invalid Age, Age should be between 0 to 120");
                return age; 
            }

            set {
                if (value<=0 || value > 120) Console.WriteLine("Invalid Age, Age should be between 0 to 120");
                age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //read only property
        public double Salary
        {
            get { return salary; }
        }

        //write only property
        public string Password
        {
            set { password = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Enter the age: ");
            student.Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("\n======= Student Information =======");
            
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine("Stipend: " + student.Salary);
            //Console.WriteLine($"Password: {student.Password}");
            Console.ReadLine();
        }
            
    }
}
