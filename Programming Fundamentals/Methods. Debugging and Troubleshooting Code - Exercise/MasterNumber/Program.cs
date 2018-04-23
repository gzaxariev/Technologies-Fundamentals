using System;

namespace p12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                if (IsSymetric(currentNumber) && 
                    (SumOfDigit(currentNumber) % 7 ==0) && 
                    ConteinsEvenDigit(currentNumber))
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }
        static bool IsSymetric(int number)
        {
            string currentNumber = number.ToString();
            int counter = 0;

            for (int i = currentNumber.Length - 1; i >= 0; i--)
            {
                if (currentNumber[i] != currentNumber[counter])
                {
                    return false;
                }
                counter++;
            }
            return true;
        }
        static int SumOfDigit(int number)
        {
            int sum = 0;
            while (number !=0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }
        static bool ConteinsEvenDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 2;
                if (digit % 2 ==0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
            
        }
    }
}
