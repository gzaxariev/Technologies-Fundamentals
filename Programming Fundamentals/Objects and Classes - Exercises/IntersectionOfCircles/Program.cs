using System;
using System.Linq;

namespace IntersectionOfCircles
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static int CalculeteDistanceBetweenPoints(Point p1, Point p2)
        {
            return (int) Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }

    class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            int d = Point.CalculeteDistanceBetweenPoints(c1.Center, c2.Center);

            if (d <= c1.Radius + c2.Radius)
            {
                return true;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleCoords = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircleCoords = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstPoint = new Point(firstCircleCoords[0], firstCircleCoords[1]);
            Point secondPoint = new Point(secondCircleCoords[0], secondCircleCoords[1]);

            Circle firstCircle = new Circle(firstPoint, firstCircleCoords[2]);
            Circle secondCircle = new Circle(secondPoint, secondCircleCoords[2]);

            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
