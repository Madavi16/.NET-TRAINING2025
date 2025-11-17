using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPaymentGateway
{
    interface IPaymentGateway
    {
        void MakePayment(double amount);
        void PaymentStatus();
    }
    

    class SmartGateway :IPaymentGateway
    {
        protected string paymentType;
        private double paymentAmount;
        private bool isSuccess;

        public SmartGateway(string type)
        {
            this.paymentType = type;
            isSuccess = false;
        }
        public void MakePayment(double amount)
        {
            this.paymentAmount = amount;
            Console.WriteLine($"\nProcessing {paymentType} Payment.... ");

            if (paymentType.Equals("Creditcard", StringComparison.OrdinalIgnoreCase)) CreditcardPayment();
            else if (paymentType.Equals("UPI", StringComparison.OrdinalIgnoreCase)) UPIpayment();
            else if (paymentType.Equals("Wallet", StringComparison.OrdinalIgnoreCase)) WalletPayment();
            else Console.WriteLine("Error!!! Invalid Payment Type!");
        }

        public void PaymentStatus()
        {
            Console.WriteLine((isSuccess) ? $"{paymentType} Payment of {paymentAmount:F2} is Successful" : $"{paymentType} is Failed");
        }

        private void CreditcardPayment()
        {
            Console.WriteLine("Verifying Card details...");
            Console.WriteLine("Processing Transaction...");
            isSuccess = true;
        }
        private void UPIpayment()
        {
            Console.WriteLine("Connecting to UPI server...");
            Console.WriteLine("Validating PIN...");
            isSuccess = true;
        }
        private void WalletPayment()
        {
            Console.WriteLine("Checking wallet balance...");
            Console.WriteLine("Deducting amount from wallet...");
            isSuccess = true;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n========== WELCOME TO SMART PAYMENT GATEWAY ==========\n");
            Console.WriteLine("Choose payment method: (CreditCard/ UPI / Wallet): ");
            string type=Console.ReadLine();

            Console.WriteLine("\nEnter payment amount: ");
            double amount=Convert.ToDouble(Console.ReadLine());

            SmartGateway gateway = new SmartGateway(type);
            gateway.MakePayment(amount);
            gateway.PaymentStatus();

            Console.ReadLine();
        }
    }
}
