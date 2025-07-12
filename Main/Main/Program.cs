using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student(123, "Антон", "Борисов");
            int num = stud;
            Console.WriteLine(num);
        }
    }
}
