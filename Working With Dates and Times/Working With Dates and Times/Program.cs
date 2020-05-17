using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_With_Dates_and_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());

            Console.WriteLine(myValue.AddDays(3).ToString());
            Console.WriteLine(myValue.AddHours(3).ToString());
            Console.WriteLine(myValue.AddHours(-3).ToString());//Subtact Days

            Console.WriteLine(myValue.Month);

            DateTime myBirthDay = new DateTime(1997, 11, 12);
            Console.WriteLine(myBirthDay.ToShortDateString());

            DateTime myBDay = DateTime.Parse("12/11/1997");
            TimeSpan myAge = DateTime.Now.Subtract(myBDay);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
