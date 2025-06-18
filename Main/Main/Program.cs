using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            RegisterBaby("Миша", new Person("Светлана", 23, null, null), new Person("Алексей", 24, null, null));
            if (typeof(Person).GetField("Mom").IsInitOnly && typeof(Person).GetField("Dad").IsInitOnly)
            {
                Console.WriteLine("Ок");
            }
        }
        public static void RegisterBaby(string name, Person mom, Person dad)
        {
            Person baby = new Person(name, 0, mom, dad);
            if (typeof(Person).GetField("Mom").IsInitOnly && typeof(Person).GetField("Dad").IsInitOnly)
            {
                Console.WriteLine("Ок");
            }
        }
    }
}
