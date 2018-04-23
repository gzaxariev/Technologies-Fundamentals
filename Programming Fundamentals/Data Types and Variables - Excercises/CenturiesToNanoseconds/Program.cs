using System;
using System.Numerics;

namespace p10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int years = numb * 100;
            double days = years * 365.2422;
            double hourse = days * 24;
            double minutes = hourse * 60;
            double secunds = minutes * 60;





            Console.WriteLine($"{numb} centuries = {numb*100} years = {(numb * 36524)} days = {numb* 876576} " +
                $"hours = {numb *52594560} minutes = {(decimal) numb * 3155673600} seconds = {(decimal)numb * 3155673600000} " +
                $"milliseconds = {(decimal)numb *3155673600000000} " +
                $"microseconds = {(decimal)numb *3155673600000000000} nanoseconds");
        }
    }
}