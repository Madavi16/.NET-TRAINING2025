using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOrMethod_Overriding
{
    internal class PaymentMethod
    {
        public virtual string Provider => "Generic Payment Provider";

        public virtual bool ProcessPayment(decimal amount)
        {
            if(amount>0)
            {
                Console.WriteLine($"Processing Payment of amount {amount}");
                return true;
            }
            return false;

        }
        public void samplePayment()
        {
            Console.WriteLine("This is a sample payment.");
        }

    }
}
