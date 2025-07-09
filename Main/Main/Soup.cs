public class Soup
{
    public Carrot Carrot { get; set; }
    public Potato Potato { get; set; }
    public Chicken Chicken { get; set; }

    public Soup(Carrot carrot, Potato potato, Chicken chicken)
    {
        Carrot = carrot;
        Potato = potato;
        Chicken = chicken;
    }
}