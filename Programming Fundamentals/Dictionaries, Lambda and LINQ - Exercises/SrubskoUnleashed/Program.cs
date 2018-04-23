﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SrubskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split().ToArray();

            int price = 0;
            int tickets = 0;
            int income = 0;
            string venue;
            string performer;

            Dictionary<string, Dictionary<string, int>> concerts = new Dictionary<string, Dictionary<string, int>>();

            while (info[0] != "End")
            {
                if (!IsValid(info))
                {
                    info = Console.ReadLine().Split().ToArray();
                    continue;
                }

                int member = 0;
                List<string> singer = new List<string>();
                for (int i = 0; i < info.Length; i++)
                {
                    if (!info[i].StartsWith("@"))
                    {
                        singer.Add(info[i]);
                    }
                    else
                    {
                        member = i;
                        break;
                    }
                }

                performer = string.Join(" ", singer);

                List<string> place = new List<string>();

                for (int i = member; i < info.Length - 2; i++)
                {
                    place.Add(info[i]);
                }

                venue = string.Join(" ", place);
                venue = venue.Remove(0, 1);
                price = int.Parse(info[info.Length - 2]);
                tickets = int.Parse(info[info.Length - 1]);
                income = price * tickets;

                if (!concerts.ContainsKey(venue))
                {
                    Dictionary<string, int> currentConcert = new Dictionary<string, int>();
                    currentConcert.Add(performer, income);
                    concerts.Add(venue, currentConcert);
                }
                else
                {
                    if (!concerts[venue].ContainsKey(performer))
                    {
                        concerts[venue].Add(performer, income);
                    }
                    else
                    {
                        concerts[venue][performer] += income;
                    }
                }
                info = Console.ReadLine().Split().ToArray();
            }

            foreach (var town in concerts)
            {
                Console.WriteLine($"{town.Key}");

                foreach (var singerAndSumPrice in town.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singerAndSumPrice.Key} -> {singerAndSumPrice.Value}");
                }
            }
        }


        static bool IsValid(string[] info)
        {
            int indexStartVenue = 0;
            bool isValid = false;
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i].StartsWith("@"))
                {
                    indexStartVenue = i;
                    isValid = true;
                }
            }

            if (isValid)
            {
                if (indexStartVenue < 1 || indexStartVenue > 3)
                {
                    isValid = false;
                }

                if (indexStartVenue > info.Length - 3 || indexStartVenue < info.Length - 5)
                {
                    isValid = false;
                }

                try
                {
                    int.Parse(info[info.Length - 1]);
                    int.Parse(info[info.Length - 2]);
                }
                catch
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
