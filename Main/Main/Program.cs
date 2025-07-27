using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main()
    {
        School school = new School();
        school.Students = new List<Student>()
    {
        new Student("Багаев Аслан", 10, 4.3),
        new Student("Абаев Георгий", 8, 5),
        new Student("Дзуцев Михаил", 2, 3.8),
        new Student("Елоев Сармат", 11, 4.6)
    };
        Console.WriteLine(school.Count(student => student.Grade > 2));
        Console.WriteLine(school.Count(student => student.FIO.Contains("Багаев")));
    }
}
