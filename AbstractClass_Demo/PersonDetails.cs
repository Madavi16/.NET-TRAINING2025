using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Demo
{
    public sealed class PersonDetails
    {
        public string Email { get; set; }
        public string LockNumber { get; set; }
        public string GenericPassword { get; set; }

        public void GetPersonDetails()
        {
            Console.WriteLine("Enter the Email, Locker Number and Generic Password:");
            Email = Console.ReadLine();
            LockNumber = Console.ReadLine();
            GenericPassword= Console.ReadLine();
            Console.WriteLine("\n=====Displaying Person Details=====\n");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"LockNumber: {LockNumber}");
            Console.WriteLine($"Generic Password: {GenericPassword}");
            Console.ReadLine();
        }
    }

    //public class EmployeeDetails : PersonDetails
    //{
    //    this will cause a compile-time error because PersonDetails class is sealed
    //}
}
