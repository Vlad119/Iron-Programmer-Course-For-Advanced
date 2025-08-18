public interface IStudent : IPerson
{
    int Course {  get; set; }
    void Learn(string subject);
}

