using System;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumber(number));


            
        }
        static string ReverseNumber(string number)
        {
            string reversedNumber = "";

            for (int i =number.Length - 1; i >= 0; i--)
            {
                reversedNumber = reversedNumber + number[i];
            }
            return reversedNumber;
        }
    }
}
