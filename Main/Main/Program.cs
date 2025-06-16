using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Student student1 = new Student("Иосиф", 16);
            Console.WriteLine(student1.GetAge());
            student1.SetAge(25);
            Console.WriteLine(student1.GetAge());
            student1.SetAge(20);
            student1.SetAge(15);
        }
    }
}
