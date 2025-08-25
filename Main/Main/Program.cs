using System;

internal class Program
{
    static void Main(string[] args)
    {
        Student[] students = 
        {
            new Student("Игорь Курчатов", 6, 4.8),
            new Student("Сергей Королёв", 7, 4.0),
            new Student("Юлий Харитон", 7, 4.5),
            new Student("Николай Вавилов", 2, 4.8),
            new Student("Михаил Калашников", 2, 4.3),
            new Student("Андрей Сахаров", 11, 3.9),
            new Student("Пётр Капица", 7, 4.5)
        };
        Array.Sort(students);
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
