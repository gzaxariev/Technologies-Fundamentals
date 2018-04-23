using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rotation = int.Parse(Console.ReadLine());
            int[] result = new int[numbers.Length];

            for (int rotations = 0; rotations < rotation; rotations++)
            {
                int lastDigit = numbers[numbers.Length - 1];

                for (int index = numbers.Length - 1; index > 0; index--)
                {
                    numbers[index] = numbers[index - 1];
                    result[index] += numbers[index];

                }

                numbers[0] = lastDigit;
                result[0] += numbers[0];
            }

            for (int index = 0; index < result.Length; index++)
            {
                Console.Write(result[index] + " ");
            }

            Console.WriteLine();



        }

    }
}
