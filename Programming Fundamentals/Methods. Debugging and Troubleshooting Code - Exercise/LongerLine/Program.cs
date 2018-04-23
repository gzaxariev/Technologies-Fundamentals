using System;

namespace p09
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxDistance = double.MinValue;
            double maxX1 = 0;
            double maxY1 = 0;
            double maxX2 = 0;
            double maxY2 = 0;

            for (int i = 0; i < 2; i++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                double currentDistance = CalculatDistance(x1, y1, x2, y2);
                if (currentDistance > maxDistance)
                {
                    maxDistance = currentDistance;
                    maxX1 = x1;
                    maxY1 = y1;
                    maxX2 = x2;
                    maxY2 = y2;
                }
            }
            PrintCloserPoint(maxX1, maxY1, maxX2, maxY2);
  
        }
        static double CalculatDistance ( double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return distance;
        }
        static void PrintCloserPoint(double x1, double y1, double x2, double y2)
        {
            double firstPosition = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondPosition = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstPosition <= secondPosition)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }
    }
}
