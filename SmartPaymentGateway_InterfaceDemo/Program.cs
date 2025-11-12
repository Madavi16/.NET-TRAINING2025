using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPaymentGateway_InterfaceDemo
{
    interface IPaymentProcessor
    {
        void MakePayment(decimal amount); //abstarct method
        
    }
    class RefudablePaymentProcessor
    {
        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Refunding payment of {amount:C} ");
        }
    }


    class PayPalProcessor : RefudablePaymentProcessor, IPaymentProcessor,Logger 
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now} : {message}");
        }
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:F2} through PayPal.");
        }
        //public void RefundPayment(decimal amount)
        //{
        //    Console.WriteLine($"Refunding payment of {amount:F2} through PayPal.");
        //}
    }
    class UPIPayment :RefudablePaymentProcessor, IPaymentProcessor,Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now} : {message}");
        }
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:F2} through UPI.");
        }
        //public void RefundPayment(decimal amount)
        //{
        //    Console.WriteLine($"Processing payment of {amount:F2} through UPI.");
        //}
    }

    class WalletPayment : IPaymentProcessor,Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now} : {message}");
        }
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:F2} through Wallet.");
        }
        //public void RefundPayment(decimal amount)
        //{
        //    Console.WriteLine($"Processing payment of {amount:F2} through Wallet.");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPaymentProcessor processor = new PayPalProcessor();
            Console.WriteLine("Enter your amount: ");
            decimal amount=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be refund: ");
            decimal refundamount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose your type of payment: (PayPal / UPI / Wallet): ");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    //IPaymentProcessor processor = new PayPalProcessor();
                    //processor.MakePayment(amount);
                    //RefudablePaymentProcessor refund = new RefudablePaymentProcessor();
                    //refund.RefundPayment(amount);
                    PayPalProcessor payPalProcessor = new PayPalProcessor();
                    payPalProcessor.MakePayment(amount);
                    payPalProcessor.RefundPayment(refundamount);
                    payPalProcessor.Log($"Payment of {amount} made through paypal.");
                    break;
                case 2:
                    //IPaymentProcessor processor1 = new UPIPayment();
                    //processor1.MakePayment(amount);
                    //processor1.RefundPayment(amount); 
                    UPIPayment upi = new UPIPayment();
                    upi.MakePayment(amount);
                    upi.RefundPayment(refundamount);
                    upi.Log($"Payment of {amount} made through UPI");
                    break;
                case 3:
                    IPaymentProcessor processor3 = new WalletPayment();
                    processor3.MakePayment(amount);
                    WalletPayment wallet = new WalletPayment();
                    wallet.Log($"Payment of {amount} made through .")
                    //processor3.RefundPayment(amount)
                        ; break;
                default:
                    Console.WriteLine("Invalid Payment type");
                    break;
            }
            Console.ReadKey();
           
        }
    }
}
