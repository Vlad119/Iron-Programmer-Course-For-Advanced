public class Person : User
{
    private int age;

    public Person(string name, int age) : base(name)
    {
        this.age = age;
    }

    public void Subscribe(User user)
    { }

    public override string GetInfo()
    {
        return $"Имя={base.GetInfo().Split('=')[1]}, Возраст={age}";
    }
}