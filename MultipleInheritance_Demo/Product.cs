using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance_Demo
{
    interface Product
    {
        void GetProductInfo();
        void DisplayProductInfo();
        
    }

    interface Review
    {       
        void GetReview();
        void DisplayReview();       
        
    }

    public class Customer : Product, Review
    {
         int ProductID { get; set; }
         string ProductName { get; set; }
        double Price { get; set; }
        public void GetProductInfo()
        {
            Console.WriteLine("Enter the product id : ");
            ProductID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name : ");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            Price = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Id: {ProductID}");
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Product Price: {Price}");
        }


        public static int ReviewId { get; set; } = 0;
        public string Comments { get; set; }
        public int Ratings { get; set; }
        public int CustomerId { get; set; }

        public void GetReview()
        {
            Console.WriteLine("Enter the customer id: ");
            CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your comments: ");
            Comments = Console.ReadLine();
            Console.WriteLine("Enter your ratings: ");
            Ratings = Convert.ToInt32(Console.ReadLine());
            ReviewId++;
        }
        public void DisplayReview()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Comments : {Comments}");
            Console.WriteLine($"Ratings: {Ratings}");
        }
    }
}
