using System;

public class Student : IComparable<Student>
{
    public string FIO; // имя
    public int Grade; // класс
    public double Performance; // средний балл

    public Student(string fio, int grade, double performance)
    {
        FIO = fio;
        Grade = grade;
        Performance = performance;
    }

    public int CompareTo(Student other)
    {
        int result = Grade.CompareTo(other.Grade);
        if (result != 0) return result;
        result = Performance.CompareTo(other.Performance);
        if (result != 0) return result;
        return FIO.CompareTo(other.FIO);
    }

    public override string ToString()
    {
        return $"Имя: {FIO}, Класс: {Grade}, Средний балл: {Performance}";
    }

}
