public class Equipment
{
    public Item[] items;

    public Equipment(Item[] items)
    {
        this.items = items;
    }

    public int GetWeightOfEquipment()
    {
        int totalWeight = 0;
        foreach (var item in items)
        {
            totalWeight += item.weight;
        }
        return totalWeight;
    }
}