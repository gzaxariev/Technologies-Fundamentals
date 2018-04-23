using System;
using System.Collections.Generic;
using System.Data;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool[] primes = new bool[number + 1];

            for (int index = 2; index < primes.Length; index++)
            {
                primes[index] = true;
            }

            for (int index = 2; index <= Math.Sqrt(number); index++)
            {
                if (primes[index])
                {
                    for (int j = index * index; j <= number; j += index)
                    {
                        primes[j] = false;
                    }
                }
            }

            List<int> result = new List<int>();

            for (int index = 0; index < primes.Length; index++)
            {
                if (primes[index])
                {
                    result.Add(index);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
