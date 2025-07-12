using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(1, "Сергей", "Березов");
            string s = (string)stud1;
            Console.WriteLine(s);
        }
    }
}
