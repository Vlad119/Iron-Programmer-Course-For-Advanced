using System;

internal class Program
{
    static void Main(string[] args)
    {
        IStudent student = new Student("Josef");
        Console.WriteLine(student.Name);
        student.ListeningLection();
        student.DoHomework("123");
        student.PrepareForExam();
    }
}

public class Student : IStudent
{
    public Student(string value)
    {
         Name = value;
    }

    public string Name { get; set; }

    public void DoHomework(string value)
    {
        Console.WriteLine("DoHomework");
    }

    public void ListeningLection()
    {
        Console.WriteLine("ListeningLection");
    }

    public void PrepareForExam()
    {
        Console.WriteLine("PrepareForExam");
    }
}