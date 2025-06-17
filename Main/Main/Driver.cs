using System;

public class Driver
{
    public readonly Guid Id;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Driver(string name, string lastname, int age)
    {
        Id = Guid.NewGuid();
        FirstName = name;
        LastName = lastname;
        Age = age;
    }
}