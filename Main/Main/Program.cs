namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserProfile usProf = new UserProfile("Алина") { Gender = "Жен" };
            usProf.DisplayUserInfo();
        }
    }
}
