using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierApp
{
    abstract class ShippingCalculator
    {
        public abstract decimal Calculate(decimal weight, string zone);

        public virtual string Label()
        {
            return "Generic Shipping Service.";
        }

    }

    class StandardShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            
            decimal baseRate=50m;
            decimal costPerKg=20m;

            if (zone.ToLower() == "north" || zone.ToLower() == "south" || zone.ToLower() == "east" || zone.ToLower() == "west") costPerKg += 5m;

            return baseRate+(weight*costPerKg);
        }
        public override string Label()
        {
            return "Standard Shipping (3-5 days)";
        }
    }

    class ExpressShipping: ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal baseRate = 100m;
            decimal costPerkg = 35m;
            if (zone.ToLower() == "north" || zone.ToLower() == "south" || zone.ToLower()=="east" || zone.ToLower()=="west") costPerkg += 10m;
            

                return baseRate + (weight * costPerkg);
        }
        public override string Label()
        {
            return "Express Shipping (1-2 days)";
        }
    }
    class InternationalShipping:ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal baseRate = 300m;
            decimal costPerKg = 80m;
            if (zone.ToLower() == "asia" || zone.ToLower()=="Europe") costPerKg -= 30m;
            return baseRate+(weight* costPerKg);
        }
        public override string Label()
        {
            return "International Shipping (5-10 days)";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===== Courier Shipping Calculator =====\n");
            Console.WriteLine("Enter the weight: ");
            decimal weight=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter zone: (North/Sount/East/West/Asia/Europe): ");
            string zone=Console.ReadLine();

            Console.WriteLine("Select Shipping Type: ");
            Console.WriteLine("1.Standard Shipping\n2.Express Shipping\n3.International Shipping");
            int choice=Convert.ToInt32(Console.ReadLine());

            ShippingCalculator calculator;

            switch (choice)
            {
                case 1:
                    calculator = new StandardShipping();
                    break;
                case 2:
                    calculator = new ExpressShipping();
                    break;
                case 3:
                    calculator = new InternationalShipping();
                    break;
                default:
                    Console.WriteLine("Invalid choice! Defaulting to Standard.");
                    calculator = new StandardShipping();
                    break;
            }

            decimal cost = calculator.Calculate(weight, zone);

            Console.WriteLine($"\nShipping Type: {calculator.Label()}");
            Console.WriteLine($"Calculated Shipping Cost: {cost:F2}");
            Console.ReadLine();
        }
    }
}
