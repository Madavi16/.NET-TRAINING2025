using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSolutions
{
   internal class Vehicle
   {
        private string registrationNumber;
        private string ownerName;
        protected int serviceCount;
        protected string model;

        public Vehicle(string regNo, string owner, string model)
        {
            Console.WriteLine("Base class Constructor");
            registrationNumber = regNo;
            ownerName = owner;
            this.model = model;
            serviceCount = 0;
        }

        private void ShowRegistration()
        {
            Console.WriteLine($"Vehicle Registration Number: {registrationNumber}");
        }

        protected void DisplayBasicInfo()
        {
            Console.WriteLine($"Displaying basic vehicle info: ");
            Console.WriteLine($"Owner Name: {ownerName}");
            Console.WriteLine($"Vehicle Model: {model}");
        }

        public void DisplayVehicleInfo()
        {
            Console.WriteLine("\n========== Vehicle Information ==========\n");
            ShowRegistration();
            DisplayBasicInfo();
            Console.WriteLine($"Service Count: {serviceCount}");

        }
        public void UpdateServiceCount()
        {
            serviceCount++;
            Console.WriteLine($"\nService count of the vehicle is updated as: {serviceCount}");
        }
    }

   internal class Car : Vehicle
    {
        private string carType;
        private string FuelType;

        public Car(string regNo, string owner, string model,string cType,string fType) : base(regNo, owner, model)
        {
            Console.WriteLine("\nDerived class constructor");
            this.carType = cType;
            this.FuelType = fType;
        }

        public void PerformInspection()
        {
            Console.WriteLine("\n--------- Performing Vehicle Inspection ---------\n");
            Console.WriteLine($"Car Type: {carType}\nFuel Type: {FuelType}");
            Console.WriteLine("\nInspection Completed Successfully!\n");
        }

        public void PerformMaintenance()
        {
            Console.WriteLine("\n---------- Performing Maintenance -----------\n");
            DisplayBasicInfo();
            Console.WriteLine("\nMaintenance work Completed successfully!\n");
            UpdateServiceCount();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n======== AutoCare Solutions -- Vehicle Maintenance System =======\n");
            string regNo,owner,model, cType, fType;
            Console.WriteLine("Enter Registration number: ");
            regNo = Console.ReadLine();

            Console.WriteLine("Enter Owner Name: ");
            owner = Console.ReadLine();
            Console.WriteLine("Enter model: ");
            model = Console.ReadLine();
            Console.WriteLine("Enter Car Type: ");
            cType = Console.ReadLine();
            Console.WriteLine("Enter Fuel Type: ");
            fType = Console.ReadLine();
            Car car = new Car(regNo,owner,model,cType,fType);

            car.DisplayVehicleInfo();
            car.PerformInspection();
            car.PerformMaintenance();

            Console.WriteLine("\n======= Car Maintenance record updated successfully! ======\n");
            Console.ReadLine();
        }
    }
}
