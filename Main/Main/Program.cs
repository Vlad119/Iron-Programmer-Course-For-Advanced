internal class Program
{
    static void Main(string[] args)
    {
        Gun pistol = new Pistol(3, 5);
        pistol.Shoot();
        pistol.Shoot();
        pistol.Shoot();
        pistol.Shoot();
        Gun sniperWeapon = new SniperWeapon(2, 10, 300);
        sniperWeapon.Shoot();
        sniperWeapon.Shoot();
        sniperWeapon.Shoot();
    }
}
