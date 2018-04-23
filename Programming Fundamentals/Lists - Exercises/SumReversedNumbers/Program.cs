using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(' ').ToList();


            int result = 0;
            

            for (int i = 0; i < inputList.Count; i++)
            {
                string reversed = "";
                string currentNumber = inputList[i];
                for (int j = currentNumber.Length-1; j >= 0; j--)
                {
                    reversed += currentNumber[j];
                }

                result += int.Parse(reversed);
            }

            Console.WriteLine(result);
        }
    }
}
