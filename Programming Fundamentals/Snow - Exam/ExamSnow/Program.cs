using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


class ExamSnow
{
    static void Main()
    {
        int numb = int.Parse(Console.ReadLine());

        BigInteger sum = 0;
        BigInteger result = 0;
        List<BigInteger> maxResult = new List<BigInteger>();
        var snow = 0;
        var time = 0;
        var quality = 0;
        BigInteger max = 0;
        for (int i = 0; i < numb; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            sum = (snowballSnow / snowballTime);
            result = BigInteger.Pow(sum, snowballQuality);
            maxResult.Add(result);

            if (result > max)
            {
                max = result;
                snow = snowballSnow;
                time = snowballTime;
                quality = snowballQuality;
            }
        }

        Console.WriteLine($"{snow} : {time} = {max} ({quality})");
    }
}

