using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begining_To_Advance
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = "Coding";
            Console.WriteLine("Hello World");
            Console.WriteLine("Test the {0}", code);


            int[] arr = new int[10];
            for(int i=0;i<arr.Length;i++)
            {
               arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }

            string mystring = string.Format("{0:C}", 123.45);
            Console.WriteLine(mystring);



            Console.ReadLine();
        }
    }
}
