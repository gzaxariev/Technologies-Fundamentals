using System;
using System.Text.RegularExpressions;

namespace RegexSnow
{
    class Program
    {
        static void Main(string[] args)
        {
            string surface = Console.ReadLine();
            string mantle = Console.ReadLine();
            string middle = Console.ReadLine();
            string mantleTwo = Console.ReadLine();
            string surfaceTwo = Console.ReadLine();


            string surfacePattern = @"[^A-Za-z0-9]+";
            var surfaceRegex = new Regex($"^{surfacePattern}$");

            if (!surfaceRegex.IsMatch(surface))
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (!surfaceRegex.IsMatch(surfaceTwo))
            {
                Console.WriteLine("Invalid");
                return;
            }

            string mantlePattern = @"[0-9_]+";
            var mantleRegex = new Regex($"^{mantlePattern}$");

            if (!mantleRegex.IsMatch(mantle))
            {
                Console.WriteLine("Invalid");
                return;
            }
            if (!mantleRegex.IsMatch(mantleTwo))
            {
                Console.WriteLine("Invalid");
                return;
            }

            string middlePattern = @"[A-Za-z]+";
            var middleRegex = new Regex($"^{surfacePattern}{mantlePattern}{middlePattern}{mantlePattern}{surfacePattern}$");

            if (!middleRegex.IsMatch(middle))
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.WriteLine("Valid");

            var match = middleRegex.Match(middle);
            Console.WriteLine(match.Groups[1].Value.Length);






        }
    }
}
