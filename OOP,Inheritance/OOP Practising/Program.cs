using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practising
{
    class Van
    {
        private string brandName;
        private int maxSpeed;

        public string BrandName
        {
            get
            {
                return brandName;
            }
            set
            {
                brandName = value;
            }
        }
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                maxSpeed = value;
            }
        }
        public virtual void Drive()
        {
            Console.WriteLine("I try to drive van.");
        }
    }
    class Car:Van
    {
        public override void Drive()
        {
            Console.WriteLine("I try to drive car.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive();

            Van van = new Van();
            van.Drive();
            van.BrandName = "Toyota";
            Console.WriteLine(van.BrandName);

            car.BrandName = "Ferrari";
            Console.WriteLine(car.BrandName);

            Console.ReadLine();
        }
    }
}
