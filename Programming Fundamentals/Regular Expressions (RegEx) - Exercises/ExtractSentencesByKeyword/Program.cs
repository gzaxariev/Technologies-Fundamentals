using System;
using System.Text.RegularExpressions;

namespace Extract_entencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string[] text = Console.ReadLine().Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentence in text)
            {
                var words = Regex.Split(sentence, @"[^A-Za-z0-9]+");

                foreach (var word in words)
                {
                    if (word == key)
                    {
                        Console.WriteLine(sentence.Trim());
                        break;
                    }
                }
            }
        }
    }
}
