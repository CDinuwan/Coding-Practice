using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int A = 1;
            Console.WriteLine(A + A);
            /* string
             * char
             * int 
             * double
             * bool
             * decimal
             * float
             */

            //Use slide bar to escape sequence
            int[] luckyNumbers = { 4, 8, 15, 76, 23 };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
        }
    }
}
