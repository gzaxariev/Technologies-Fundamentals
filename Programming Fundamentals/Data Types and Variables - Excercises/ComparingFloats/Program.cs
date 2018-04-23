using System;

namespace p16
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (Math.Abs(first - second )< eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }




        }
    }
}
