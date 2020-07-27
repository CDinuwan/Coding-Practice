using System;
using System.Collections.Generic;

namespace Practise_CSharp
{
    class Car
    {
        private string color;
        public Car(string color)
        {
            this.color = color;
        }
        Car car = new Car("Red");



    }
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            Console.WriteLine(num1);
            num1 = 1;
            Console.WriteLine(num1);
            List<string> listOfName = new List<string>()
        {
            "Chanuka Dinuwan",
            "Dinuwan",
            "Jan Doe"
        };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(listOfName[i]);
            }
        }

        enum Days { Sun, Mon, Tue, Wed, Thu };
    }
}