using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace StudetnsAverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double Average => Grades.Average();
    }

    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            while (input-- > 0)
            {
                Student student = new Student();

                string[] studentsInfo = Console.ReadLine().Split();
                string studentsName = studentsInfo[0];


                student.Name = studentsName;

                student.Grades = studentsInfo.Skip(1).Select(double.Parse).ToList();


                students.Add(student);
            }


            students.Where(s => s.Average >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Average)
                .ToList()
                .ForEach(s => { Console.WriteLine($"{s.Name} -> {s.Average:F2}"); });
        }
    }
}
