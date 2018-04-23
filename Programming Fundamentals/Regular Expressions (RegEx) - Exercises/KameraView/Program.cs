using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string text = Console.ReadLine();

            string pattern = @"\|<(.*?)(?=\||$)";

            var matches = Regex.Matches(text, pattern);

            List<string> camera = new List<string>();

            foreach (Match item in matches)
            {
                string element = string.Concat(item.Groups[1].ToString().Skip(elements[0]).Take(elements[1]).ToArray());
                camera.Add(element);
            }
            Console.WriteLine(string.Join(" ", camera));
        }
    }
}
