using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopBilling
{
    internal class Item
    {
        public string itemName;
        public int quantity;
        public double pricePerUnit;

        public void CalculateItemTotal(out double itemTotal)
        {
            itemTotal = quantity * pricePerUnit;
        }
        
        public void DisplayItem(double itemTotal)
        {
            Console.WriteLine($"{itemName,-15} {quantity,-10} {pricePerUnit,-15:C}{itemTotal,-10:C}");
        }

    }
}
