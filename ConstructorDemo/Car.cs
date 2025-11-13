using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class Car
    {
        string brand;
        string model;

        public Car(string b, string m)
        {
            brand = b;
            model = m;
        }
        public Car(Car c)
        {
            brand = c.brand;
            model = c.model;
        }

        public void Display()
        {
            Console.WriteLine("\nCopy constructor:");
            Console.WriteLine($"Brand: {brand}\nModel: {model}");
        }
        
    }
}
