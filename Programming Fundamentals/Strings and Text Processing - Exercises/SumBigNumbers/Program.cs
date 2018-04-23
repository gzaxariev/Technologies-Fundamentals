using System;
using System.Linq;
using System.Text;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int sum = 0;
            int remainder = 0;
            int nym = 0;

            if (first.Length > second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            }
            else
            {
                first = first.PadLeft(second.Length, '0');
            }

            StringBuilder sb = new StringBuilder();
            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = first[i] - 48 + second[i] - 48 + remainder;
                nym = sum % 10;

                if (sum > 9)
                {
                    remainder = 1;
                }
                else
                {
                    remainder = 0;
                }

                sb.Append(nym);

                if (i == 0 && remainder == 1)
                {
                    sb.Append(remainder);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd('0').Reverse().ToArray());
        }

    }
}
