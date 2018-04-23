using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double mile = 1.60934;

            Console.WriteLine($"{n * mile:f2}");
        }
    }
}
