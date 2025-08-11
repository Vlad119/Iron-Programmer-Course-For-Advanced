using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        User user = new User("Ivan Ivanov", "ivanov@yandex.ru", "123321");

        UserManager userManager = new UserManager();
        TwoFactorAuthentication twoFactorAuthentication = new TwoFactorAuthentication(userManager);
        twoFactorAuthentication.TurnOn();

        userManager.Register(user);
    }

}
