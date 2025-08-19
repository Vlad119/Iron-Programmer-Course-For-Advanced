public class Flat
{
    public int Number { get; set; }
    public int RoomsCount { get; set; }
    public override string ToString()
    {
        return $"Квартира с номером {Number} имеет {RoomsCount} комнат";
    }
}
