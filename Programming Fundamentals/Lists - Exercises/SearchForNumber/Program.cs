using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().
                Split(new char[] {' '}).
                Select(int.Parse).
                ToList();

            int [] conditions = Console.ReadLine().
                Split(new char[] { ' ' }).
                Select(int.Parse).
                ToArray();

            List<int> result = new List<int>();

            int elementsToTake = conditions[0];

            int elementToDelete = conditions[1];

            for (int i = 0; i < elementsToTake; i++)
            {
                result.Add(inputList[i]);
            }

            for (int i = 0; i < elementToDelete; i++)
            {
                result.RemoveAt(0);
            }

            if (result.Contains(conditions[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }






        }
    }
}
