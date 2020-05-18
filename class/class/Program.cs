using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Car//Creating class
    {

        public string make;
        public string color;

        public void StartDrivingCar()
        {
            Console.WriteLine("We are going to ride a Car");
        }
        public Car(string Color, string Make)
        {
            this.color = Color;
            this.make = Make;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car("Blue","Honda");//Constructor

            Console.WriteLine("My car color is {0} and It's {1}", mycar.color, mycar.make);

            float val=DeterminemarketValue(mycar);
            Console.WriteLine("{0:C}", val);//Format

            Console.ReadLine();
        }

        private static float DeterminemarketValue(Car car)
        {
            float carValue = 100;
            return carValue;
            
        }
    }
}
