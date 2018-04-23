using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(new char[] {' '}).Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < number.Count; i++)
            {
                int currentNumber = number[i];
                var square = Math.Sqrt(currentNumber);

                if (square == (int)square)
                {
                    result.Add(currentNumber);
                }

            }
            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join(" ", result ));

        }
    }
}
