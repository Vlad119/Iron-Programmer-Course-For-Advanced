public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public readonly Person Mom;
    public readonly Person Dad;

    public Person(string name, int age, Person mom, Person dad)
    {
        Name = name;
        Age = age;
        Mom = mom;
        Dad = dad;
    }
}