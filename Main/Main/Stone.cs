namespace Main
{
    public class Stone 
    {
        public Lava Lava { get; set; }
        public Air Air { get; set; }

        public Stone(Lava l, Air a)
        {
           Lava = l;
           Air = a;
        }
    }
}
