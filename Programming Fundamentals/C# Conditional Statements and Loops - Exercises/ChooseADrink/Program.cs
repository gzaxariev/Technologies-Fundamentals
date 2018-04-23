using System;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            if (profession == "Athlete")
            {
                Console.WriteLine("Water");
            }
            if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            if (profession == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            if (profession != "Athlete" && profession != "Businessman" && profession != "Businesswoman" && profession != "SoftUni Student")
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
