using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_E_Commerce_Order_Fulfillment_Platform
{
    public class OrderProcessorBase
    {
        private IPricingStrategy pricing;
        private IPaymentProvider payment;
        private IShippingQuoter shipper;
        private INotifier notifier;

        public OrderProcessorBase(IPricingStrategy pricing, IPaymentProvider payment, IShippingQuoter shipper, INotifier notifier)
        {
            this.pricing = pricing;
            this.payment = payment;
            this.shipper = shipper;
            this.notifier = notifier;
        }
        public void ProcessOrder(IOrder order)
        {
            Console.WriteLine("\n===== Start Order Processing =====");
            double SubTotal=order.CalculateSubTotal();
            double total = pricing.CalculateTotal(SubTotal);
            Console.WriteLine($"\nSubTotal: {SubTotal}\nTotal after discount: {total}");

            string authId;
            if(payment is RazorPayProvider)
            {
                authId = ((RazorPayProvider)payment).StartPayment();
            }
            else
            {
                authId=((StripeProvider)payment).StartPayment();
            }


            double shipcost = shipper.GetQuote(order.CalculateTotalWeight(), order.GetCity());
            Console.WriteLine($"Shipping Cost: {shipcost}");

            payment.CapturePayment(authId);
            notifier.Notify($"\nOrder for {order.GetBuyer()} shipped to {order.GetCity()}!");
            Console.WriteLine("\nOrder saved successfully in databases (simulated).");

        }
    }

}
