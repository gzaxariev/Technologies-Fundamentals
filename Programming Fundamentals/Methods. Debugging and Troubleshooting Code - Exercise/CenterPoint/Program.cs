using System;

namespace p08
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrdoubleCloserPodouble(x1, y1, x2, y2);

        }
        static void PrdoubleCloserPodouble(double x1, double y1, double x2, double y2)
        {
            double firstPosition = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondPosition = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstPosition < secondPosition)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }
    }
}
