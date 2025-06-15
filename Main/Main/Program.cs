public class Student
{
    public string FirstName = "Неизвестное имя";
    public string LastName = "Неизвестная фамилия";

    public Student()
    {
        FirstName = "Unknown FirstName";
        LastName = "Unknown LastName";
    }

    public string Print()
    {
        return FirstName + " " + LastName;
    }
}