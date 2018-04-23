using System;
using System.Linq;
using System.Numerics;

namespace StringsAndTextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            int first = int.Parse(input[0]);

            BigInteger second = BigInteger.Parse(input[1]);

            BigInteger reminder = 0;

            string result = "";

            while (second > 0)
            {
                reminder = second % first;
                second /= first;
                result = reminder.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}
