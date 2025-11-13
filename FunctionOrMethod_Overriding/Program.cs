using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOrMethod_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            CreditCardPayment creditCard=new CreditCardPayment();
            creditCard.ProcessPayment(amount);
            creditCard.samplePayment();
            Console.WriteLine($"{creditCard.Provider}");
            CashOnDelivery delivery=new CashOnDelivery();
            delivery.ProcessPayment(amount);
            Console.WriteLine($"{delivery.Provider}");
            Console.ReadLine();
        }
    }
}
