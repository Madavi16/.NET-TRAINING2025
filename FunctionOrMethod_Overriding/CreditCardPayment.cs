using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOrMethod_Overriding
{
    internal class CreditCardPayment:PaymentMethod
    {
        public override string Provider => "Credit Card Provider";

        public override bool ProcessPayment(decimal amount)
        {
            base.ProcessPayment(amount);
            if(amount>0 && amount<=5000)
            {
                Console.WriteLine($"Processing credit card payment of amount: {amount}");
                return true;
            }
            else
            {
                Console.WriteLine($"Processing payment with credit card is failed.");
                return false;
            }
        }
    }
}
