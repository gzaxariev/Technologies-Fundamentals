using System;
using System.Collections.Generic;
using System.Linq;

class Dworf
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Physics { get; set; }
}

class SnowWhite
{
    static void Main(string[] args)
    {
        Dictionary<string, List<Dworf>> colorsToDworf = new Dictionary<string, List<Dworf>>();
        List<Dworf> allDworfs = new List<Dworf>();

        while (true)

        {

            string input = Console.ReadLine();

            if (input == "Once upon a time")
            {
                break;
            }

            var dworfInfo= input.Split(" <:> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var name = dworfInfo[0];
            var color = dworfInfo[1];
            var physics =int.Parse( dworfInfo[2]);

            if (!colorsToDworf.ContainsKey(color))
            {
                colorsToDworf[color] = new List<Dworf>();
            }

            var dworfsByCurrentColor = colorsToDworf[color];

           var foundDworf =  dworfsByCurrentColor.
               FirstOrDefault(d => d.Name == name);

            if (foundDworf != null)
            {
                foundDworf.Physics = Math.Max(physics, foundDworf.Physics);
            }
            else
            {
                var dworf = new Dworf
                {
                    Name = name,
                    Color = color,
                    Physics = physics,
                };
                dworfsByCurrentColor.Add(dworf);
                allDworfs.Add(dworf);
            }
            var result = allDworfs.OrderByDescending(d => d.Physics).ThenByDescending(d => colors)


        }
        
    }

}

