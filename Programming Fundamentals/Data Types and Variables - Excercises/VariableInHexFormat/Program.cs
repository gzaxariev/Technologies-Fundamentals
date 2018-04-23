using System;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool output = Convert.ToBoolean(input);
           // Console.WriteLine(output);

            if (output)
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
