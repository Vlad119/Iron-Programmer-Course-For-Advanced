using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Dog dog = new Dog("Песик", 2);
            Console.WriteLine(dog.GetDescription());
            Console.WriteLine(dog.Speak("Woof Woof"));
            Console.WriteLine(dog.Speak("Bow Wow"));
        }
    }
}
