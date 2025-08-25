using System;

public class Student
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

    public override string ToString()
    {
        return $"Имя: {FIO}, Класс: {Grade}, Средний балл: {Performance}";
    }

}
