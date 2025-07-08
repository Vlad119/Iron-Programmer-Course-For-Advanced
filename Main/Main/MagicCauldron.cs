
internal class MagicCauldron
{
    public LovePotion MakePotion(RedCarnation redCarnation, WhiteRose whiteRose, IvyBush ivyBush)
    {
        return new LovePotion();
    }

    public DeathPotion MakePotion(WhiteRose whiteRose, IvyBush ivyBush, RedCarnation redCarnation)
    {
        return new DeathPotion();
    }
}

