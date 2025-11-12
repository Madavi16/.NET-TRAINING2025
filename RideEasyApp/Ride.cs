using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp
{
    internal class Ride
    {
        public Customer customer;
        public Vehicle vehicle;
        public decimal distance;
        public DateTime rideDate;

        public Ride(Customer c, Vehicle v, decimal d, DateTime date)
        {
            this.vehicle = v;
            this.customer = c;
            this.distance = d;
            this.rideDate= date;

        }
        public void ComputeBill(out decimal subtotal,out decimal gst, out decimal total,params string[] addOns)
        {
            subtotal = (vehicle.baseFare) + (vehicle.perKmRate * distance);
            decimal AddonCost = Pricing.AddOnsCost(addOns);
            subtotal += AddonCost;

            if(Pricing.TryGetWeekendSurcharge(rideDate,out decimal weekendPercent))
            {
                decimal surCharge = subtotal * weekendPercent;
                subtotal += surCharge;
            }

            gst = Pricing.CalculateGST(subtotal);
            total = subtotal + gst;
        }

        public void PrintInvoice(string[] addOns, decimal subtotal, decimal gst, decimal totalBeforeDiscount, decimal finalTotal, decimal couponUsed, bool usedLoyalty, decimal callByValueTotal, int remainingPoints)
        {
            Console.WriteLine("\n========== RideEasy Invoice ==========\n");
            Console.WriteLine($"Date: {rideDate:dd-MM-yyyy (ddd)}");
            Console.WriteLine($"Customer: {customer.customerName} ({customer.customerID}");
            Console.WriteLine($"Vehicle: {vehicle.vehicleType}");
            Console.WriteLine($"Distance: {distance} km");
            Console.WriteLine($"Add-Ons: {string.Join(",", addOns)}");
            Console.WriteLine("\n--------------------------------------------------\n");
            Console.WriteLine($"Subtotal:\t {subtotal:F2}");
            Console.WriteLine($"GST (18%):\t {gst:F2}");
            Console.WriteLine($"Total (before):\t {totalBeforeDiscount:F2}");
            Console.WriteLine($"Coupon (By REF):\t -applied {couponUsed:F2}");
            Console.WriteLine($"Loyalty Reedem:\t\t -applied {(usedLoyalty?"up to available loyalty points": "none")}");
            Console.WriteLine("\n---------------------------------------------------\n");
            Console.WriteLine($"Final Payable:\t {finalTotal:F2}");
            Console.WriteLine("\n---------------------------------------------------\n");
            Console.WriteLine($"(Demonstration) Call-by-Value coupon attempt did NOT change total: {callByValueTotal:F2}");
            Console.WriteLine($"Remaining Loyalty Points: {remainingPoints}");
            Console.WriteLine("\n======================================\n");
            Console.ReadLine();
        }
    }
}
