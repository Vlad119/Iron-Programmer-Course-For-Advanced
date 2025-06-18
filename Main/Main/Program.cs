using System;

public class Program
{
    public static void Main()
    {
        Person mom = new Person("Светлана", 20, null, null);
        Person dad = new Person("Алексей", 20, null, null);
        Person baby = new Person("Паша", 0, mom, dad);
        Console.WriteLine($"Mom age: {baby.Mom.Age}");
        Console.WriteLine($"Dad age: {baby.Dad.Age}");
        UpdateMomAge(baby);
        UpdateDadAge(baby);
        Console.WriteLine($"Mom age: {baby.Mom.Age}");
        Console.WriteLine($"Dad age: {baby.Dad.Age}");
    }

    public static void UpdateMomAge(Person person)
    {
        if (person.Mom != null)
        {
            person.Mom.Age++;
        }
    }

    public static void UpdateDadAge(Person person)
    {
        if (person.Dad != null)
        {
            person.Dad.Age++;
        }
    }
}