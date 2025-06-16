namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Item item1 = new Item();
            Item item2 = new Item("Меч", 10);
            Item item3 = new Item("Лук", 5, "Возгорание");
            Item item4 = new Item("Щит", 15, "Дополнительный урон");
            item1.ShowItem();
            item2.ShowItem();
            item3.ShowItem();
            item4.ShowItem();
        }
    }
}
