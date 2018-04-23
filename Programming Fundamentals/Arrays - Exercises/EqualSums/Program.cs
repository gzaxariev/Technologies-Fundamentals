using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int[] firstArr = arr.Take(i).ToArray();
                int[] secondArr = arr.Skip(i + 1).ToArray();

                if (firstArr.Sum() == secondArr.Sum())
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
