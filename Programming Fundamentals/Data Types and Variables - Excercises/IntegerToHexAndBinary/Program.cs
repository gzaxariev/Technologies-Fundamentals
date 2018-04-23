using System;

namespace p14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(numb, 2);
            string hexadecimal = Convert.ToString(numb, 16).ToUpper();

            
            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);





        }
    }
}
