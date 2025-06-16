using System;

public class Student
{
    private string name;
    private int age;

    public Student(string name, int age)
    {
        SetName(name);
        SetAge(age);
    }
    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        if (value.Length <= 1)
        {
            throw new Exception("Имя должно состоять как минимум из 2 букв.");
        }

        foreach (char c in value)
        {
            if (!char.IsLetter(c))
            {
                throw new Exception("Имя должно состоять только из букв.");
            }
        }
        name = value;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int value)
    {
        if (value < 16)
        {
            throw new Exception("Возраст должен быть не меньше 16 лет.");
        }
        if (value < age)
        {
            throw new Exception("Новый возраст не может быть меньше предыдущего.");
        }
        age = value;
    }
}