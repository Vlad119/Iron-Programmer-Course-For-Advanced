using System;

public class Client
{
    public readonly Guid Id;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string CardNumber { get; set; }

    public Client(string firstName, string lastName, int age, string cardNumber)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        CardNumber = cardNumber;
    }
}