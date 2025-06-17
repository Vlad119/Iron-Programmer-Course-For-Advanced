using System;

public class Student
{
    private string name;
    private int age;
    
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length <= 1)
            {
                throw new Exception("Имя должно состоять как минимум из 2 букв.");
            }
            foreach (var c in value)
            {
                if (!char.IsLetter(c))
                {
                    throw new Exception("Имя должно состоять только из букв.");
                }
            }
            name = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }
        set
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

    public Student(string name, int age)
    {
        Name = name;
        Age = age; 
    }
}