using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising1
{
    class Program
    {
        static void binarySearch(int[] arr,int length)
        {
            
            for(int i=0;i<length;i++)
            {
                int val = arr[i];
                int num = arr[i++];
                int count = 1;
                if(val==num)
                {
                    count++;
                    Console.WriteLine(val);
                    break;
                }

            }
            
        }
        
        static void Main(string[] args)
        {
            int[] sortNum = { 1, 1, 3, 4, 5, 6, 7, 8 };
            int arrayLengh = sortNum.Length;

            binarySearch(sortNum, arrayLengh);

            Console.ReadLine();
        }
    }
}
