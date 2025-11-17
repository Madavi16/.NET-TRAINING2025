using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_Checkout
{
    class Store
    {
        public void Checkout(int price)
        {
            Console.WriteLine($"Total Amount: {price}");
        }
        public void Checkout(int price, int quantity)
        {
            int total = price * quantity;
            Console.WriteLine($"Price: {price}\nQuantity: {quantity}\nTotal Amount: {total}");
        }
        public void Checkout(string couponCode)
        {
            if(couponCode=="SAVE10".ToLower().ToLower())
            {
                Console.WriteLine("Coupon applied: SAVE10-> 10% discount on your next purchase!");
            }
            else if (couponCode == "SAVE20")
            {
                Console.WriteLine("Coupon applied: SAVE20-> 20% discount on your next purchase!");
            }
            else
            {
                Console.WriteLine("Invalid Coupon Code!");
            }
        }
        public void Checkout(int price, int quantity, string couponCode)
        {
            int total=price * quantity;
            double discount = 0;
            if(couponCode=="SAVE10".ToLower())
            {
                discount = 0.10 * total;
            }
            else if(couponCode=="SAVE20".ToLower())
            {
                discount = 0.20 * total;
            }

            double finalAmount = total - discount;

            Console.WriteLine("\n Purchase Invoice: \n");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Coupon Code: {couponCode}");
            Console.WriteLine($"Discount: {discount:F2}");
            Console.WriteLine($"Final Amount: {finalAmount:F2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store=new Store();
            Console.WriteLine("Enter the price: ");
            int price=Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Enter quantity: ");
            int quantity=Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Enter coupon code: ");
            string couponCode=Console.ReadLine();

            Console.WriteLine("\n========== Online Store Checkout ==========\n");
            Console.WriteLine("Checkout with price only: ");
            store.Checkout(price);
            Console.WriteLine("Checkout with price and quanitity: ");
            store.Checkout(price, quantity);
            Console.WriteLine("Checkout with coupon code only: ");
            store.Checkout(couponCode);
            Console.WriteLine("Checkout with price, quantity and coupon code: ");
            store.Checkout(price,quantity,couponCode);
            Console.ReadLine();

        }
    }
}
