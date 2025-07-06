
internal class Resume : Profile
{
    public int Age { get; set; }
    public Resume(string name, int age) : base(name)
    {
        Age = age;
    }

    protected override string GetInfo()
    {
        return $"Стаж работы: {Age}";
    }
}

