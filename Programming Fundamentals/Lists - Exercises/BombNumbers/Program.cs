using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(new char[] {' '}).Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToList();

            int bombNumber = commands[0];
            int power = commands[1];

            while (number.Contains(bombNumber))
            {
                int position = number.IndexOf(bombNumber);
                if (position - power < 0 && position + power > number.Count)
                {
                    number.Clear();
                }
                else if (position - power < 0)
                {
                    number.RemoveRange(0, 1+power + position);
                }
                else if (position + power < number.Count)
                {
                    number.RemoveRange(position - power, power + 1 + number.Count - 1 - position);
                }
                else
                {
                    number.RemoveRange(position - power, 2*power +1);
                }
            }

            int sum = number.Sum();
            Console.WriteLine(sum);

        }
    }
}
