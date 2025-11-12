using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_E_Commerce_Order_Fulfillment_Platform
{
    public interface IPaymentProvider
    {
        string AuthorizePayment();
        void CapturePayment(string authId);
    }

    public abstract class PaymentProviderBase : IPaymentProvider
    {
        private string lastAuthId;
        protected bool paymentAuthorized = false;

        public string AuthorizePayment()
        {
            paymentAuthorized = true;
            lastAuthId = "AUTHCODE123";
            Console.WriteLine($"Payment authorize successfully. Auth Code: {lastAuthId}");
            return lastAuthId;

        }

        public void CapturePayment(string authId)
        {
            if (authId == lastAuthId)
            {
                Console.WriteLine("Payment captured successfully.");
            }
            else
            {
                Console.WriteLine("Error: Invalid Authorization code.");
            }
        }
    }
        public sealed class RazorPayProvider: PaymentProviderBase
        {
            public string StartPayment()
            {
                Console.WriteLine("[RazorPay] Starting Payment Process...");
                return AuthorizePayment();
            }
        }

        public sealed class StripeProvider: PaymentProviderBase
        {
            public string StartPayment()
            {
                Console.WriteLine("[Stripe] Staring Payment Process...");
                return AuthorizePayment();
            }
        }
    
}
