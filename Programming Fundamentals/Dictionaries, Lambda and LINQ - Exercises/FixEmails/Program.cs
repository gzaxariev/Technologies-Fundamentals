using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> namesAndEmals = new Dictionary<string, string>();

            string commands = Console.ReadLine();

            List<string> contains = new List<string>();

            while (commands != "stop")
            {
                string mails = Console.ReadLine();
                if (!namesAndEmals.ContainsKey(commands))
                {
                    namesAndEmals.Add(commands,mails);
                    
                }
                


                commands = Console.ReadLine();
            }

            foreach (var item in namesAndEmals.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
