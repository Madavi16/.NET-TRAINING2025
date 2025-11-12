using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Department dept=new Department();
            //default constructor
            dept.DisplayDepartmentInfo();

            Console.WriteLine("\nEnter new department details\n-----------------------------");

            dept.getDepartmentInfo();
            dept.DisplayDepartmentInfo();

            //parameterized constructor
            Department dept2 = new Department(1807031,"Infra","Hyderabad");
            dept2.DisplayDepartmentInfo();


            //copy constructor
            Car car1 = new Car("Tesla", "Model X");
            Car car2 = new Car(car1); //copying car1 data
            //Car car3 = new Car(car2);
           
            car2.Display();
            //car3.Display();

            

            Console.ReadLine();
        }
    }
}
