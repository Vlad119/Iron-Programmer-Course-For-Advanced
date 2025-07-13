public class Person
{
    public static int Age { get; set; }
    public static int LegalAge { get; set; } = 18;

    public Person(int age)
    {
        Age = age;
    }

    public static int IncreaseLegalAge(int age)
    {
        return LegalAge++;
    }

    public bool IsAdult()
    {
        return Age >= LegalAge;
    }
}
