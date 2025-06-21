public class Driver : User
{
    public char Category { get; set; }

    public Driver (string name, int age, char cat)
    {
        Name = name;
        Age = age;
        Category = cat;
    }
}