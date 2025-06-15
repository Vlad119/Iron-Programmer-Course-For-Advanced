public class Person
{
    public string firstName;
    public string lastName;
    public int age;

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public string GetFullName()
    {
        return $"{lastName} {firstName}";
    }

    public bool IsAdult()
    {
        return age >= 18;
    }
}
