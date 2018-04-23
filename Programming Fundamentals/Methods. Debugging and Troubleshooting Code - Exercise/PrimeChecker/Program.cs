using System;

namespace p06
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));

        }
        static bool IsPrime(long number)
        {
            if (number ==0 || number == 1)
            {
                return false;
            }
            bool isPrime = false;

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i ==0)
                return false;
            }
            return true;
        }
    }
}
