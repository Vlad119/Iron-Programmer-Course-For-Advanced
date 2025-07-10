namespace Main
{
    public class Lava
    {
        public Fire Fire { get; set; }
        public Ground Ground { get; set; }

        public Lava(Fire f, Ground g)
        {
            Fire = f;
            Ground = g;
        }

        public static Stone operator +(Lava l, Air a)
        {
            return new Stone(l, a);
        }
    }
}
