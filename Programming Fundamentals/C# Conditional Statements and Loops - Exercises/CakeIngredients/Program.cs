using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingrediant = Console.ReadLine();
            int counter = 0;

            while (ingrediant != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingrediant}.");
                counter++;
                ingrediant = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
