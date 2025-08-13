internal class Program
{
    static void Main(string[] args)
    {
        User user = new User("Ivan Ivanov", "ivanov@yandex.ru", "123321");
        UserManager userManager = new UserManager();
        var advertisement = new Advertisement(userManager);
        advertisement.TurnOn();
        userManager.Register(user);
    }
}
