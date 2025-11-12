using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperty
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        
        public string Email { get; set; }

        public string PhoneNum { get; set; }

        public void DisplayCustomerInfo ()
        {
            Console.WriteLine("\n===== Customer Details =====\n");
            Console.WriteLine($"Customer ID: {CustomerID}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNum}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("\nEnter the customer Id, Name, Email, Phone Number: \n");
            customer.CustomerID=Convert.ToInt32( Console.ReadLine());
            customer.CustomerName=Console.ReadLine();
            customer.Email=Console.ReadLine();
            customer.PhoneNum=Console.ReadLine();

            customer.DisplayCustomerInfo();
            Console.ReadKey();
        }
    }
}
