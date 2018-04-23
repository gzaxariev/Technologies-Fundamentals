using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price = 0.0;
            string place = "";

            if (groupSize <= 50)
            {
                place = "Small Hall";
                price += 2500;
            }
            else if (groupSize <= 100)
            {
                place = "Terrace";
                price += 5000;
            }
            else if (groupSize <= 120)
            {
                place = "Great Hall";
                price += 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            switch (package)
            {
                case "Normal":
                    price += 500;
                    price *= 0.95;
                    break;

                case "Gold":
                    price += 750;
                    price *= 0.9;
                    break;

                case "Platinum":
                    price += 1000;
                    price *= 0.85;
                    break;

            }
            Console.WriteLine($"We can offer you the {place}\r\nThe price per person is {price / groupSize:F2}$");
        }
    }
}
