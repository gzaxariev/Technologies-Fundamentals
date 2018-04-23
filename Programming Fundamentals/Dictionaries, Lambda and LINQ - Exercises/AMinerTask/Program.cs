using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int>  mine = new Dictionary<string, int>();

            string commands = Console.ReadLine();
            string metal = "";

            int quentity = 0;

            while (commands != "stop")
            {
                metal = commands;
                quentity = int.Parse(Console.ReadLine());
                if (!mine.ContainsKey(metal))
                {
                    mine.Add(metal, quentity);
                }
                else
                {
                    mine[metal] += quentity;
                }

                commands = Console.ReadLine();

            }

            foreach (var item in mine)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
