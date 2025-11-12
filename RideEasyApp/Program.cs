using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RideEasy App");
            Console.WriteLine("Enter Customer Name:");
            string custName=Console.ReadLine();

            Console.WriteLine("Enter CustomerId: ");
            int custId=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Loyalty Points: ");
            int loyaltyPoints=Convert.ToInt32(Console.ReadLine());

            Customer customer=new Customer(custId,custName,loyaltyPoints);

            Console.WriteLine("\nSelect vehicle type: (1)Hatchbook (2)Sedan (3)SUV");
            Console.WriteLine("Enter your choice: ");
            int choice=Convert.ToInt32(Console.ReadLine());

            string vehicleType;
            decimal baseFare, perKm;
            switch(choice)
            {
                case 1:
                    vehicleType = "HatchBook";
                    baseFare = 100;
                    perKm = 10;
                    break;
                case 2:
                    vehicleType = "Sedan";
                    baseFare = 150;
                    perKm=20;
                    break;
                case 3:
                    vehicleType = "SUV";
                    baseFare = 200;
                    perKm=30;
                    break;
                default:
                    vehicleType = "Sedan";
                    baseFare=100;
                    perKm = 20;
                    break;
            }

            Vehicle vehicle=new Vehicle(vehicleType, baseFare, perKm);

            Console.WriteLine("Enter distance travelled (km): ");
            decimal distance=Convert.ToDecimal(Console.ReadLine());
            if (distance <= 0) distance = 10.0m;

            Console.WriteLine("\nEnter add-ons (comma separated): child-seat, fast-tag, priority-pickup, extra-luggage");
            Console.WriteLine("Add-ons: ");
            string[] addOns=Console.ReadLine().Split(',');

            Ride ride = new Ride(customer, vehicle, distance, DateTime.Now);

            ride.ComputeBill(out decimal subtotal, out decimal gst, out decimal totalbeforediscount, addOns);
            decimal callbyValuetotal = totalbeforediscount;
            Pricing.TryApplyCoupon_byValue(callbyValuetotal,50);

            decimal finalTotal = totalbeforediscount;
            Pricing.ApplyCoupon_ByRef(ref finalTotal, 50);

            int oldPoints = customer.loyaltyPoints;
            Pricing.ReedemLoyalty(ref customer.loyaltyPoints, ref finalTotal);

            bool usedLoyalty = oldPoints != customer.loyaltyPoints;

            ride.PrintInvoice(addOns, subtotal, gst, totalbeforediscount, finalTotal, 50, usedLoyalty, callbyValuetotal, customer.loyaltyPoints);
            Console.ReadLine();

        }
    }
}
