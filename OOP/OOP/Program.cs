 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Vehicle
    {
        public abstract void Drive();
        private int fuelLevel;
        private string vehicleType;

        public void StartDrive()
        {
            Console.WriteLine("Starting Drive");
        }
        public int FuelLevel
        {
            get
            {
                return fuelLevel;
            }
            set
            {
                fuelLevel = FuelLevel;
            }

        }
        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = VehicleType;
            }
        }
    }
    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Start Driving Car");
            CarDriving();
        }
        private void CarDriving()
        {
            Console.WriteLine("Driving Car Carefully");
        }
    }
    class Van:Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Start Driving Van");
            VanDriving();
        }
        private void VanDriving()
        {
            Console.WriteLine("Driving Van Carefully");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Details");
            Console.WriteLine();
            Vehicle car = new Car();
            car.FuelLevel = 45;
            car.VehicleType = "Four Wheel Vehicle";
            car.Drive();
            car.StartDrive();
            Console.WriteLine("Vehicle Fuel Level "+car.FuelLevel);
            Console.WriteLine();

            Console.WriteLine("Van Details");
            Console.WriteLine();
            Vehicle van = new Van();
            van.FuelLevel = 85;
            van.VehicleType="Four Wheel";
            van.Drive();
            van.StartDrive();
            Console.WriteLine(van.VehicleType);

            Console.ReadLine();

        }
    }
}
