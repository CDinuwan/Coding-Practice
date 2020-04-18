using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    public interface Vehicle
    {
        string Describe();

        int FuelLevel
        {
            get;
            set;
        }
    }
    public class Car:Vehicle
    {
        public int fuelevel;

        public int FuelLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Describe()
        {
            return "Hello";
        }
        public Car(int Fuellevel)
        {
            this.fuelevel = Fuellevel;
        }
    }
    class Program
    {
        static void CheckParam(params string[] name)
        {
            foreach(string i in name)
            {
                Console.WriteLine(i);
            }
        }
        public static void NonReturn()
        {
            Console.WriteLine("Non Returning class");
        }
        public static int AddNum(int num1,int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args) {
            const double pie= 3.14;
            
            List<string> ListNames = new List<string>()
            {
                "Chanuka",
                "Dinuwan",
                "Hewa",
                "Ellewelage"
            };
            foreach(string i in ListNames)
            {
                Console.WriteLine(i);
            }

            Vehicle car = new Car(89);

            Console.WriteLine(AddNum(12,30));
            Console.WriteLine(pie);

            NonReturn();

            CheckParam("Chanuka", "Dinuwan", "Testing");
            

            Console.ReadLine();
        }
    }
}
