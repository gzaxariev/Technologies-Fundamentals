using System;

namespace p15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int toChek = 2; toChek <=number; toChek++)
            {
                bool isPrime = true;
                for (int current = 2; current <= Math.Sqrt(toChek); current++)
                {
                    if (toChek % current == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{toChek} -> {isPrime}");
            }

        }
    }
}
