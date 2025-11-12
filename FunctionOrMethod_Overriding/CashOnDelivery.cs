using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOrMethod_Overriding
{
    internal class CashOnDelivery
    {
        public virtual string Provider => "Cash On Delivery Provider";

        public virtual bool ProcessPayment(decimal amount)
        {
            if(amount >5000&& amount<=10000)
            {
                Console.WriteLine($"Processing Cash On Delivery of amount: {amount}");
                return true;
            }
            else
            {
                Console.WriteLine("Cash on Delivery is not supported to the payment amount.");
                return false;
            }

        }
    }
}
