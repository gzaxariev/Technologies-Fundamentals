using System;
using System.Linq;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string w1 = input[0];
            string w2 = input[1];

            int l1 = w1.ToCharArray().Distinct().Count();
            int l2 = w2.ToCharArray().Distinct().Count();

            if (l1 == l2)
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
