using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod_Demo
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle: run for pre-run check");
        }
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("Car: start with key");
        }
    }

    public class ElectricCar : Car
    {
        public sealed override void Start()
        {
            base.Start();
            Console.WriteLine("ElectricCar: Start with button");
        }
    }

    //we cannot inherit a sealed method in another class
    //this following override should cause a compile time error

    //public class HybridCar : ElectricCar
    //{
    //    public override void Start()
    //    {
    //        base.Start();
    //        Console.WriteLine("HybridCar: Starts with Hybrid system");
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {

            ElectricCar myelectricCar = new ElectricCar();
            myelectricCar.Start();
            //double x = 10.25; 
            //Console.Write(Convert.ToInt32(x));
            //bool x = true; Console.Write(Convert.ToString(x));
            Console.ReadLine();
        }
    }

}