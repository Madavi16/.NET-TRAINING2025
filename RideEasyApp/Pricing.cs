using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp
{
    internal static class Pricing
    {
        public static decimal CalculateGST(decimal amount)
        {
            return amount * 0.18m; //GST 18%
        }
        public static bool TryGetWeekendSurcharge(DateTime rideDate, out decimal percent)
        {
            if (rideDate.DayOfWeek == DayOfWeek.Sunday || rideDate.DayOfWeek == DayOfWeek.Saturday)
            {
                percent = 0.10m; //surcharge
                return true;
            }
            percent = 0m;
            return false;
        }

        public static decimal AddOnsCost(params string[] addOns)
        {
            decimal total = 0m;
            foreach(string addOn in addOns)
            {
                switch(addOn.ToLower())
                {
                    case "child-seat": 
                        total += 50; 
                        break;

                    case "fast-tag":
                        total += 30;
                        break;

                    case "priority-pickup":
                        total += 70;
                        break;

                    case "extra-luggage":
                        total += 40;
                        break;

                }
            }
            return total;
        }
        public static void TryApplyCoupon_byValue(decimal total, decimal couponAmount)
        {
            total -= couponAmount;
        }
        public static void ApplyCoupon_ByRef(ref decimal total, decimal couponAmount)
        {
            total -= couponAmount;
        }

        public static void  ReedemLoyalty(ref int points,ref decimal total)
        {
            if (points > 0)
            {
                decimal discount = points;
                if (discount > total) discount = total;
                total -= discount;
                points -= (int)discount;
            }

           
        }
    }
}
