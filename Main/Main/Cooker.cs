public class Cooker
{
    public Soup MakeSoup(Carrot carrot, Chicken chicken, Potato potato)
    {
        return new Soup(carrot, potato, chicken);
    }

    public Soup MakeSoup(Chicken chicken, Carrot carrot, Potato potato)
    {
        return new Soup(carrot, potato, chicken);
    }

    public Soup MakeSoup(Chicken chicken, Potato potato, Carrot carrot)
    {
        return new Soup(carrot, potato, chicken);
    }
}
