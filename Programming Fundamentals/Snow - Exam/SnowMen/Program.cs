using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


class SnowMen
{
    static void Main()
    {

        List <int> snowMen = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        while (snowMen.Count > 1)
        {
            var indexToRemove = new List<int>();
            for (int i = 0; i < snowMen.Count; i++)
            {
                if (snowMen.Count(x => x != -1) == 1)
                {
                    break;
                }
                if (snowMen[i] == -1)
                {
                    continue;
                }
                var attacker = i;
                int target = snowMen[i] % snowMen.Count;

                int diff = Math.Abs(attacker - target);

                if (attacker == target)
                {
                    // suicide
                    snowMen[attacker] = -1;
                    Console.WriteLine($"{attacker} performed harakiri");
                    indexToRemove.Add(attacker);
                }
                else if (diff % 2 == 0)
                {
                    // attacker wins
                    snowMen[target] =- 1;
                    Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                    indexToRemove.Add(target);
                }
                else 
                {
                    //target wins
                    snowMen[attacker] = -1;
                    Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    indexToRemove.Add(attacker);


                }

            }

            snowMen = snowMen.Where(x => x != -1)
                .ToList();
        }

    }
}

