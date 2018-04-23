using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int result = 0;
            int totalOccurance = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int currentOccurance = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        currentOccurance++;
                        if (currentOccurance > totalOccurance)
                        {
                            totalOccurance = currentOccurance;
                            result = currentNumber;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
