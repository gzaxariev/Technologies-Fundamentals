using System;

namespace p11
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float secunds = float.Parse(Console.ReadLine());

            float time = secunds + minutes * 60 + hours * 3600;

            float mPerSec =(float)distance / time;
            float kmPerSec = ((float)distance / 1000 ) / (float)(time/3600);
            float mpPerSec = ((float)(distance / 1609)) / (float)(time / 3600);

            Console.WriteLine($"{mPerSec:0.######}");
            Console.WriteLine($"{kmPerSec:0.######}");
            Console.WriteLine($"{mpPerSec:0.######}");

        }
    }
}
