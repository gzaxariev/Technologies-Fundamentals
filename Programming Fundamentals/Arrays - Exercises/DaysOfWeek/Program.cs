using System;
using System.Linq;

namespace ArraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] days =
            {
                "Monday",
                "Wednesday",
                "Tuesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine());

            if (day <= 0 || day > 7)
            {
                Console.WriteLine("Invalid day");
                return;
            }
            string dayInEnglish = days[day -1];
            Console.WriteLine(dayInEnglish);
        }
    
        
    }
}
