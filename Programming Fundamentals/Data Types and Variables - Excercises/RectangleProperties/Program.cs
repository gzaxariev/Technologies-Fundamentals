using System;

namespace p12
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double c = 0;
            double p = 0;
            double a = 0;


           c= ( w*w)  + (h*h);
            p = 2*(w + h);
            a = w * h / 2 * 2;


            Console.WriteLine(p);
            Console.WriteLine(a);
            Console.WriteLine(Math.Sqrt(c));

        }
    }
}
