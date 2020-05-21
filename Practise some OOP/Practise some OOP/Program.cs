using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_some_OOP
{
    class Car
    {
        public string engineCapasity;
        public string fuelLevel;
        private int modelyear;
        public Car()
        {

        }//How to return value get with contructor to private variables


       public virtual void Drive()//How to inherite class with Their constructor value
        {
            Console.WriteLine("I driving a car.");
        }
    }
    class Van : Car
    {
        
        public override void Drive()
        {
            Console.WriteLine("I try to drive a car");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Details");
            Car mycar = new Car();
            mycar.Drive();

            Van myvan = new Van();
            Console.WriteLine();
            Console.WriteLine("Van Details");
            myvan.Drive();

            Console.ReadLine();
        }
    }
}
