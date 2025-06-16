class Character
{
    public Equipment equipment;

    public Character()
    {
        Item sword = new Item("Меч", 10);
        Item bow = new Item("Лук", 5);
        Item[] items = { sword, bow };
        equipment = new Equipment(items);
    }
}