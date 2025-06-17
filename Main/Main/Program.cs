using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Student student1 = new Student("Иосиф", 16);
            Console.WriteLine(student1.Age);
            student1.Age = 25;
            Console.WriteLine(student1.Age);
            student1.Age = 20;
            student1.Age = 15;
        }
    }
}
