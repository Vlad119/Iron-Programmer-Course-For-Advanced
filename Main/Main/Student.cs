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

    private void SetAge(int value)
    {
        if (value < 16)
        {
            throw new Exception("Возраст должен быть 16 или больше.");
        }
        age = value;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        if (value.Length <= 1)
        {
            throw new Exception("Имя должно состоять как минимум из двух букв.");
        }
        foreach (char c in value)
        {
            if (!char.IsLetter(c))
            {
                throw new Exception("Имя должно состоять только букв.");
            }
        }
        name = value;
    }
}