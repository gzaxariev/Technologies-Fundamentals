using System;
using System.Linq;


namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] secondArr = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            int length = Math.Min(firstArr.Length, secondArr.Length);
            int qualElements = 0;

            for (int index = 0; index < length; index++)
            {
                if (firstArr[index] == secondArr[index])
                {
                    qualElements++;
                }
            }

            Array.Reverse(firstArr);
            secondArr = secondArr.Reverse().ToArray();

            int reverseCounter = 0;

            for (int index = 0; index < length; index++)
            {
                if (firstArr[index] == secondArr[index])
                {
                    reverseCounter++;
                }
            }

            if (reverseCounter > qualElements)
            {
                Console.WriteLine(reverseCounter);
            }
            else
            {
                Console.WriteLine(qualElements);
            }

        }
    }
}
