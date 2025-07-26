using System;
using System.Collections.Generic;

namespace Stepik
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> group = new List<Student> {
            new Student("Паша", 45),
            new Student("Гриша", 58),
            new Student("Сергей", 63),
            new Student("Олег", 87)
            };

            //Console.WriteLine("Надо сдавать зачет:");

            //Вывод автоматов
            //Console.WriteLine("Автоматы:");
            //Show(group, x => x.Mark > 85);

            //Вывод незачетов
            //Console.WriteLine("Незачет:");
            //Show(group, x => x.Mark < 51);

            Console.WriteLine("Надо сдавать зачет:");
            Show(group, student => student.Mark > 50 && student.Mark < 86);
        }
        // здесь напишите метод Show

        static void Show(List<Student> students, Func<Student, bool> criteria)
        {
            foreach (var student in students)
            {
                if (criteria(student))
                {
                    Console.WriteLine($"{student.Name} - {student.Mark}");
                }
            }
        }
    }
}