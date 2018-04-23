using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            int sum = 0;
            int remainder = 0;
            int num = 0;

            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }
            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                sum = (num1[i] - 48) * num2 + remainder;
                num = sum % 10;
                
                if (sum > 9)
                {
                    remainder = sum / 10;
                }
                else
                {
                    remainder = 0;
                }

                sb.Append(num);
               
            }
            if (remainder > 0)
            {
                sb.Append(remainder);
            }
            Console.WriteLine(sb.ToString().TrimEnd('0').Reverse().ToArray());
        }
    }
}
