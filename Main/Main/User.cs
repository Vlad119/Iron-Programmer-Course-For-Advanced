public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static bool operator >(User u1, User u2)
    {
        return u1.Age > u2.Age;
    }

    public static bool operator <(User u1, User u2)
    {
        return u1.Age < u2.Age;
    }
}