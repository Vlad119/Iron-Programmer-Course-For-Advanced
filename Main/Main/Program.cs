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

public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string GetFullName()
    {
        return $"{LastName} {FirstName}";
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}