using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_E_Commerce_Order_Fulfillment_Platform
{
    class Order:IOrder
    {
        private string buyer, city;
        private double item1Price,item2Price,weight1,weight2;

        public Order(string buyer, string city)
        {
            this.buyer = buyer;
            this.city = city;
          
        }
        public void AddItem(string itemName, double price, double weight)
        {
            if(item1Price==0)
            {
                item1Price = price;
                weight1 = weight;
            }
            else
            {
                item2Price=price;
                weight2 = weight;
            }
        }
        public double CalculateSubTotal() => item1Price + item2Price;
        public double CalculateTotalWeight() => weight1 + weight2;
        public string GetBuyer() => buyer;
        public string GetCity() => city;

    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n========== Welcome to Ride Easy Commerce System ==========");
            Console.WriteLine("Enter Buyer Email: ");
            string buyer=Console.ReadLine();

            Console.WriteLine("Enter City Name: ");
            string city=Console.ReadLine();

            Order order=new Order(buyer, city);
            Console.WriteLine("Enter number of items: ");
            int n =Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Enter itemName #{i+1}: ");
                string itemName=Console.ReadLine();
                Console.WriteLine($"Enter the price of item #{i+1}: ");
                double price=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Enter the weight of the item: #{i+1}: ");
                double weight=Convert.ToDouble(Console.ReadLine());

                order.AddItem(itemName, price, weight);
            }

            IPricingStrategy strategy = new TieredDiscountStrategy();
            IPaymentProvider payment = new StripeProvider();
           IPaymentProvider payment1 = new RazorPayProvider();
            IShippingQuoter shipper1 = new DelhiveryQuoter();
            IShippingQuoter shipper = new BlueDartQuoter();
            INotifier notifier = new EmailNotifier();
            INotifier notifier1 = new SMSNotifier();
            
            OrderProcessorBase processor = new OrderProcessorBase( strategy, payment, shipper, notifier );
            OrderProcessorBase processor1 = new OrderProcessorBase( strategy, payment1, shipper1, notifier1 );

            processor.ProcessOrder( order );
            processor1.ProcessOrder(order);

            Console.WriteLine("\nOrder completed successfully");
            Console.ReadLine();

        }
    }
}
