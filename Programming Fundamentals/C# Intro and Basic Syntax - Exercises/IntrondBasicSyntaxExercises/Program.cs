using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n:d4} {j:d4} {k:d4} {m:d4}");
        }
    }
}
