using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopBilling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Smart Grocery Billing System =====");
            Console.Write("Enter number of items: ");
            int numItems = Convert.ToInt32(Console.ReadLine());

            List<Item> itemList=new List<Item>();
            double grandTotal = 0;

            for (int i = 1; i <= numItems; i++)
            {
                Console.WriteLine($"\nEnter details for Item #{i}");
                Item item = new Item();

                Console.Write("Enter item name: ");
                item.itemName=Console.ReadLine();

                Console.Write("Enter quantity: ");
                item.quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price per unit: ");
                item.pricePerUnit= Convert.ToInt32(Console.ReadLine());

                item.CalculateItemTotal(out double itemTotal);
                grandTotal += itemTotal;

                itemList.Add(item);
            }

            Console.WriteLine("\n===== BILL SUMMARY =====");
            Console.WriteLine($"{"Item",-15} {"Qty",-10} {"Unit price",-15} {"Total",-10}");
            Console.WriteLine(new string('-',55));

            foreach(var item in itemList)
            {
                item.CalculateItemTotal(out double total);
                item.DisplayItem(total);
            }
            Console.WriteLine(new string ('-',55));

            double discountPercent = 0;

            if (grandTotal > 5000)
                discountPercent = 20;
            else if (grandTotal >= 2000 && grandTotal <= 4999)
                discountPercent = 10;
            else if (grandTotal >= 1000 && grandTotal <= 1999)
                discountPercent = 5;
            else
                discountPercent = 0;

            double discountAmount = (grandTotal * discountPercent) / 100;
            double finalAmount = grandTotal - discountAmount;


            Console.WriteLine($"\nGross Total : {grandTotal}");
            Console.WriteLine($"Discount ({discountPercent}%): -{discountAmount}");
            Console.WriteLine($"Final Payable Amount: {finalAmount}");

            Console.WriteLine("\n===== Thank You! Visit Again! =====");

            Console.ReadLine();
        }
    }
}
