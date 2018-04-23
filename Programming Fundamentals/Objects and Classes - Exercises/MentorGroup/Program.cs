using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> groupsList = new List<Person>();


            while (input != "end of dates")
            {
                Person currentPerson = new Person();
                List<DateTime> myDateTimes = new List<DateTime>();

                string[] commands = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = commands[0];


                for (int i = 1; i < commands.Length; i++)
                {
                    DateTime date = DateTime.ParseExact(commands[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    myDateTimes.Add(date);
                }

                bool doesExist = false;

                foreach (var person in groupsList.Where(x => x.Name.Equals(name)))
                {
                    person.AttendeDateTimes.AddRange(myDateTimes);
                    doesExist = true;
                }

                if (!doesExist)
                {
                    currentPerson.Name = name;
                    currentPerson.AttendeDateTimes = myDateTimes;
                    currentPerson.CommentList = new List<string>();
                    groupsList.Add(currentPerson);
                }

                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();

            while (input2 != "end of comments")
            {
                string[] commands = input2.Split('-').ToArray();

                string name = commands[0];
                string comments = commands[1];

                foreach (var person in groupsList.Where(x => x.Name.Equals(name)))
                {
                    person.CommentList.Add(comments);
                }

                input2 = Console.ReadLine();
            }

            foreach (var person in groupsList.OrderBy(x => x.Name))
            {
                Console.WriteLine(person.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in person.CommentList)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in person.AttendeDateTimes.OrderBy(x => x.Date))
                {
                    string dates = date.ToString("dd/MM/yyyy");
                    Console.WriteLine($"-- {dates}");
                }
            }
        }
    }

    class Person
    {
        public string Name { get; set; }

        public List<DateTime> AttendeDateTimes { get; set; }

        public List<string> CommentList { get; set; }
    }
}