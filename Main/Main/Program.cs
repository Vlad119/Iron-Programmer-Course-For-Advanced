using System;

internal class Program
{
    public static void Main()
    {
        Person person = new Person("Иосиф", "Дзеранов", 26);
        Console.WriteLine(person.GetFullName());
        Console.WriteLine(person.IsAdult());
    }
}
