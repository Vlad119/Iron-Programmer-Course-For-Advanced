public abstract class Gun
{
    public int BulletsCapacity { get; set; }
    public int Damage { get; set; }
    protected Gun(int bulletsCapacity, int damage)
    {
        BulletsCapacity = bulletsCapacity;
        Damage = damage;
    }
    public abstract void Shoot();
}