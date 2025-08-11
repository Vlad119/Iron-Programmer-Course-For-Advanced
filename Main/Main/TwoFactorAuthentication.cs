using System;

public class TwoFactorAuthentication
{
    UserManager userManager { get; }

    public TwoFactorAuthentication(UserManager userManager)
    {
        this.userManager = userManager;
    }

    private void SendCode(object sender, UserRegisteredEventArgs e)
    {
        Console.WriteLine($"Код подтверждения: {CodeGenerator.Get()} отправлен на почту: {e.Email}");
    }

    public void TurnOn()
    {
        userManager.UserRegistered += SendCode;
    }

    public void TurnOff()
    {
        userManager.UserRegistered -= SendCode;
    }
}