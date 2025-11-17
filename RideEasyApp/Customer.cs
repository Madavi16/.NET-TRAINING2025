using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp
{
    internal class Customer
    {
        public int customerID;
        public string customerName;
        public int loyaltyPoints;
        
        public Customer(int id,string name, int points)
        {
            this.customerID = id;
            this.customerName = name;
            this.loyaltyPoints = points;
        }

    }
}
