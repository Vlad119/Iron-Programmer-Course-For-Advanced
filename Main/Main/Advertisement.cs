using System;

public class Advertisement
{
    public UserManager userManager { get; }

    public Advertisement(UserManager newUser)
    {
        userManager = newUser;
    }

    private void SendAds(object sender, UserRegisteredEventArgs e)
    {
        Console.WriteLine($"Последний день приобрести курс Технология Git по скидке. Отправлено на почту {e.Email}");
    }

    public void TurnOn()
    {
        userManager.UserRegistered += SendAds;
    }

    public void TurnOff()
    {
        userManager.UserRegistered -= SendAds;
    }
}

