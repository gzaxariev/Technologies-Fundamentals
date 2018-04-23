using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            for (int i = Math.Min(first, second); i <= Math.Max(first, second); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
