using System;
using System.Linq;

internal class Program
{
    public static void Main()
    {
        User user = new User("Ivan Ivanov", "test@yandex.ru", "123321");

        UserManager userManager = new UserManager();
        userManager.Register(user);

        var foundUser = userManager.Users.FirstOrDefault(x => x.Name.Equals(user.Name) && x.Email.Equals(user.Email) && x.Password.Equals(user.Password));
        if (foundUser == null)
            throw new Exception("Ошибка в добавлении пользователя");
        else
            Console.WriteLine("Ok");
    }

}
