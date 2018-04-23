using System;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            

            var match = Regex.Match(key, @"([A-Za-z]+)[|<\\](.*?)[|<\\]([A-Za-z]+)");
            string startKey = match.Groups[1].ToString();
            string endKey = match.Groups[3].ToString();

            string text = Console.ReadLine();

            string textPattern = $"{startKey}(.*?){endKey}";

            var matches = Regex.Matches(text, textPattern);

            StringBuilder sb = new StringBuilder();

            foreach (Match item in matches)
            {
                sb.Append(item.Groups[1].ToString());
            }

            var result = sb.Length != 0 ? sb.ToString() : "Empty Result";
            Console.WriteLine(result);

        }
    }
}
