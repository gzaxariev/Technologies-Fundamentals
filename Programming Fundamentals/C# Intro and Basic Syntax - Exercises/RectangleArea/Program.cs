using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double j = double.Parse(Console.ReadLine());


            Console.WriteLine($"{n * j:f2}");
        }
    }
}
