using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentDigit = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (Math.Abs(currentDigit - arr[j]) == difference)
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
