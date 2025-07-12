public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static explicit operator User(int age)
    {
        return new User("Неизвестно", age);
    }

    public static implicit operator int(User user)
    {
        return user.Age;
    }
}