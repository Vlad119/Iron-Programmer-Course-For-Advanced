using System;
using System.Collections.Generic;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Group groupA = new Group()
            {
                Students = new List<Student>()
        {
            new Student(){Id = 1, Name = "Алексей"},
            new Student(){Id = 2, Name = "Марина"},
            new Student(){Id = 3, Name = "Дмитрий"},
            new Student(){Id = 4, Name = "Светлана"}
        }
            };

            Group groupB = new Group()
            {
                Students = new List<Student>()
        {
            new Student(){Id = 5, Name = "Алёна"},
            new Student(){Id = 6, Name = "Игорь"},
            new Student(){Id = 7, Name = "Михаил"}
        }
            };

            Group newGroup = groupA + groupB;

            foreach (Student student in newGroup.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
