namespace Main
{
    public class Fire 
    {
        public static Lava operator +(Fire f, Ground g)
        {
            return new Lava(f, g);
        }
    }
}
