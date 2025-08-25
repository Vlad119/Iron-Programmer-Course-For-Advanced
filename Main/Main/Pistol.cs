using System;

public class Pistol : Gun
{
    public Pistol(int bulletsCapacity, int damage) : base(bulletsCapacity, damage)
    { }

    public override void Shoot()
    {
        BulletsCapacity--;
        if (BulletsCapacity >= 0) Console.WriteLine($"Пиф-паф, урон : {Damage}, пуль осталось : {BulletsCapacity}");
        else Console.WriteLine("Обойма пистолета пуста");
    }
}
