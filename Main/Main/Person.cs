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
