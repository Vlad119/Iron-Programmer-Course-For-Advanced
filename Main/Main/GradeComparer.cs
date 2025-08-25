using System.Collections.Generic;

public class GradeComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        int result = x.Grade.CompareTo(y.Grade);
        if (result != 0) return result;
        return x.FIO.CompareTo(y.FIO);
    }
}
