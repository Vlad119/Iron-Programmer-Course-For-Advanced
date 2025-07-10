namespace Main
{
    public class Air
    {
        public static Stone operator +(Air a, Lava l)
        {
            return new Stone(l, a);
        }
    }
}
