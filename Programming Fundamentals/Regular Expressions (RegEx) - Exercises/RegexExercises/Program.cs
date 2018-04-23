using System;
using System.Text.RegularExpressions;

namespace RegexExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //Regex pattern = new Regex(@"(^| )[A-Za-z0-9][A-Za-z0-9.\-_]*@[A-Z-a-z-]+(\.[a-z]+)+");
            string pattern = @"(^| )[A-Za-z0-9][A-Za-z0-9.\-_]*@[A-Z-a-z-]+(\.[a-z]+)+";

            var matchches = Regex.Matches(text, pattern);

            foreach (Match username in matchches)
            {
                Console.WriteLine(username.Value.Trim());
            }

        }
    }
}
