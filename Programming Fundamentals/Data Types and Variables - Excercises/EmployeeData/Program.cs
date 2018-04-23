using System;

namespace p08
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Amanda";
            string lastname = "Jonson";
            int age = 27;
            char gender = 'f';
            long personalid = 8306112507;
            int uniqueEmployeeNumber = 27563571;

            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {lastname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalid}");
            Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");

        }
    }
}
