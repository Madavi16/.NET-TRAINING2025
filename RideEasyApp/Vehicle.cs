using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideEasyApp
{
    internal class Vehicle
    {
        public string vehicleType;
        public decimal baseFare;
        public decimal perKmRate;

        public Vehicle(string type,decimal fare,decimal rate)
        {
            this.vehicleType=type;
            this.baseFare = fare;
            this.perKmRate = rate;
        }
    }
}
