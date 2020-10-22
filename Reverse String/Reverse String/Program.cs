using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string?");
            string reverse = Console.ReadLine();
            ReverseString(reverse);
            
        }
        public static void ReverseString(string message)
        {
            char[] messageArr=message.ToCharArray();
            Array.Reverse(messageArr);
            Console.Write("Result : ");
            foreach (var item in messageArr)
            {
                Console.Write(item);
            }
            
        }
    }
    
}
