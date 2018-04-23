using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            try
            {
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch
            {
                Console.WriteLine($"{counter}");
            }
        }
    }
}
