using System;
using System.Numerics;

namespace p14
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger factoriel = CalculateFactoriel(number);
            Console.WriteLine(CalculateTrailingZeroes(factoriel));
           


        }
        static BigInteger CalculateFactoriel(BigInteger number)
        {
            BigInteger factoriel = 1;
            for (BigInteger i = 1; i <= number; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
        static int CalculateTrailingZeroes(BigInteger number)
        {
            int counter = 0;
            while (number != 0)
            {
                BigInteger digit = number % 10;
                if (digit == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                number /= 10;

            }
            return counter;
        }
    }
    
}
