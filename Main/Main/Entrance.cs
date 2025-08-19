public class Entrance 
{
    private readonly Flat[] flats;
    private int index = -1;
    public Entrance(Flat[] _flats) => flats = _flats;
    public Entrance GetEnumerator() => this;
    public Flat Current => flats[index];
    public bool MoveNext()
    {
        index++;
        return index < flats.Length;
    }
    public void Reset() => index = -1;
}