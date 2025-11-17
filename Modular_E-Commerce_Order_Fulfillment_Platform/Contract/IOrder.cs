using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_E_Commerce_Order_Fulfillment_Platform
{
    public interface IOrder
    {
        void AddItem(string itemName, double price, double weight);
        double CalculateTotalWeight();
        double CalculateSubTotal();
        string GetCity();
        string GetBuyer();

    }
}
