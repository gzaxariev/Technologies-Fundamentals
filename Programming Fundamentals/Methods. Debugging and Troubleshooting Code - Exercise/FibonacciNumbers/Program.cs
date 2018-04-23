using System;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int result = FibonacciNumber(numb);
            Console.WriteLine(result);

        }
        static int FibonacciNumber(int numb)
        {
            int result = 0;

            if(numb == 0 || numb ==1)
            {
                result = 1;
                return result;
            }
            int previousNumb = 1;
            int beforePrevius = 1;

            for (int i = 2; i <= numb; i++)
            {
                result = previousNumb + beforePrevius;
                beforePrevius = previousNumb;
                previousNumb = result;
            }
            return result;
        }
    }
}
