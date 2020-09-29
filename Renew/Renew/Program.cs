using System;

namespace Renew
{
    class Program
    {
        static void Main(string[] args)
        {
            string charname = "Rexy";
            Console.WriteLine("Hello World");

            //Variable handling and Working with strings
            string phase = "Chanuka is programmer";
            Console.WriteLine(phase.ToUpper());
            Console.WriteLine(phase.Contains("Chanuka"));
            Console.WriteLine(phase[0]);
            Console.WriteLine(phase.IndexOf("Chanuka"));
            Console.WriteLine(phase.Substring(8, 10));

            Console.WriteLine(6 + 8);//Numbers in C#
            Console.WriteLine("Hello \" World");//Escape sequences

            Console.WriteLine(Math.Abs(-4));//Working with Math function 
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(40));
            Console.WriteLine(Math.Max(4, 40));
            Console.WriteLine(Math.Round(4.6));

            //string userInput;//User Input
            //Console.WriteLine("Enter your Input");
            //userInput = Console.ReadLine();

            //int convert;
            //convert = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(convert);

            //Arrays
            int[] luckyNumbers = { 1, 2, 3, 5, 966, 49, 596 };
            Console.WriteLine(luckyNumbers[0]);

            string[] friends = new string[10];

            Console.WriteLine(SayHi("Chanuka"));

            Console.ReadLine();

            //If else statement 
            int r = 6;
            if (r > 5)
            {
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("Hello");
            }

            //Switch statement
            int dayNum = 2;
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                default:
                    dayName = "Invalid";
                    break;
            }
            Console.WriteLine(dayName);

            //While loop
            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // Two dimentional array
            int[,] numberGrid = {{1,2 },
                                 { 3,4 }};
            Console.WriteLine(numberGrid[0, 1]);
            int[,] number = new int[2, 3];

            //Exception handling
            try
            {
                //Put your code here

            }
            catch (Exception er)
            {
                //Error
            }

        }
        static string SayHi(string name)
        {
            return "Hi " + name;
        }
    }
}
