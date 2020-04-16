using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        private int hoursePower;
        private int speed;

        public virtual void Drive()
        {
            Console.WriteLine("Drive car");
        }
        public int HoursePower
        {
            get
            {
                return hoursePower;
            }
            set
            {
                hoursePower = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        
    }
    public class Van:Car
    {
        private int sec1;
        private int sec2;

        public override void Drive()
        {
            Console.WriteLine("Drive van");
        }
        public int Sec1
        {
            get
            {
                return sec1;
            }
            set
            {
                sec1 = value;
            }
        }
        public int Sec2
        {
            get
            {
                return sec2;
            }
            set
            {
                sec2 = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car van = new Van();
            Van van1 = new Van();

            car.HoursePower = 90;
            Console.WriteLine(car.HoursePower);
            car.Speed = 100;
            Console.WriteLine(car.Speed);


            van.Drive();
            car.Drive();
            van1.Sec1 = 50;
            Console.WriteLine(van1.Sec1);

            Console.ReadLine();
        }
    }
}
