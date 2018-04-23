using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(new char[] {' '},
                StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(new char[] {' '},
                StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            int lenght = Math.Min(firstArr.Length, secondArr.Length);
            bool isFirst = false;

            for (int index = 0; index < lenght; index++)
            {
                if (firstArr[index] != secondArr[index])
                {
                    if (firstArr[index] < secondArr[index])
                    {
                        isFirst = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (isFirst || firstArr.Length < secondArr.Length)
            {
                Console.WriteLine(string.Join("", firstArr));
                Console.WriteLine(string.Join("", secondArr));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArr));
                Console.WriteLine(string.Join("", firstArr));
            }
        }
    }
}
