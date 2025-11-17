using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_E_Commerce_Order_Fulfillment_Platform
{
    public interface IPricingStrategy
    {
        double CalculateTotal(double subtotal);
    }

    public class MRPStrategy: IPricingStrategy
    {
        public double CalculateTotal(double subtotal)
        {
            return subtotal;
        }
    }

    public class TieredDiscountStrategy : IPricingStrategy
    {
        public double CalculateTotal(double subtotal)
        {
            if (subtotal >= 15000) return subtotal * 0.88;
            else if (subtotal >= 5000) return subtotal * 0.95;
            else return subtotal;
        }
    }

}
