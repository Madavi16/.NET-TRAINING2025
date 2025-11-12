using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_E_Commerce_Order_Fulfillment_Platform
{
    public interface IShippingQuoter
    {
        double GetQuote(double weight, string city);
    }
    public sealed class BlueDartQuoter:IShippingQuoter
    {
        public double GetQuote(double weight,string city)
        {
            double cost = 60 + (25 * weight);
            if (city.ToLower() == "bengaluru" || city.ToLower() == "mumbai") cost *= 0.9;
            return cost;
        }

    }
    public sealed class DelhiveryQuoter:IShippingQuoter
    {
        public double GetQuote(double weight,string city)
        {
            double cost = 50 + (28 * weight);
            if (city.ToLower() == "ooty" || city.ToLower() == "leh") cost *= 1.08;
            return cost;
        }
    }
}
