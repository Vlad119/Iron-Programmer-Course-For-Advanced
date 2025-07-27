using System;
using System.Collections.Generic;

public class School
{
    public List<Student> Students;

    public int Count(Func<Student, bool> criteria)
    {
        int count = 0;
        foreach (var student in Students)
        {
            if (criteria(student)) count++;
        }
        return count;
    }
}