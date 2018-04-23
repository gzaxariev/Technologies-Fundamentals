using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] symbol = new char[26];
            int indexCounter = 0;

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                symbol[indexCounter] = letter;
                indexCounter++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                for (int j = 0; j < symbol.Length; j++)
                {
                    if (currentLetter == symbol[j])
                    {
                        Console.WriteLine($"{currentLetter} -> {j}");
                    }
                }
            }
        }
    }
}
