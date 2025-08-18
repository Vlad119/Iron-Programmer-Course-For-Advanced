public class Student : Person, IStudent, IWorker
{
    public int Year { get; set; }
    public int Salary { get; set; }

    public void DoHomework()
    { }

    public void Work()
    { }
}
