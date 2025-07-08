internal class JuiceExtractor
{
    public Juice MakeJuice(Apple apple)
    {
        return new Juice("Яблочный сок");
    }

    public Juice MakeJuice(Orange orange)
    {
        return new Juice("Апельсиновый сок");
    }

    public Juice MakeJuice(Grape grape)
    {
        return new Juice("Виноградный сок");
    }
}