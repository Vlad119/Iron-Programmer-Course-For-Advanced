public class UpdatedPhone
{
    public string Name; 
    public int Price; 
    public int Memory; 
    public bool IsAvailable; 

    public UpdatedPhone(string name) : this(name, 5000, 8, true)
    { }

    public UpdatedPhone(string name, int price) : this(name, price, 8, true)
    { }

    public UpdatedPhone(string name, int price, int memory) : this(name, price, memory, true)
    { }

    public UpdatedPhone(string name, int price, int memory, bool isAvailable)
    {
        Name = name;
        Price = price;
        Memory = memory;
        IsAvailable = isAvailable;
    }
}