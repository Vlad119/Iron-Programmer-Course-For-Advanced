
using System;

public class SniperWeapon : Gun
{
    public int MaxDistance { get; set; }
    public SniperWeapon(int bulletsCapacity, int damage, int maxDistance) : base(bulletsCapacity, damage)
    {
        MaxDistance = maxDistance;
    }

    public override void Shoot()
    {
        BulletsCapacity--;
        if (BulletsCapacity >= 0) Console.WriteLine($"Ба-бах, урон : {Damage}, пуль осталось : {BulletsCapacity}, максимальная дистанция: {MaxDistance}");
        else Console.WriteLine("Обойма снайперской винтовки пуста");
    }
}
