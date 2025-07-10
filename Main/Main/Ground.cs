namespace Main
{
    public class Ground
    {
        public static Lava operator +(Ground g, Fire f)
        {
            return new Lava(f, g);
        }
    }
}
