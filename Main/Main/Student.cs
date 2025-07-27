public class Student
{
    public readonly string FIO;
    public readonly int Grade;
    public readonly double Performance;

    public Student(string fio, int grade, double performance)
    {
        FIO = fio;
        Grade = grade;
        Performance = performance;
    }
}