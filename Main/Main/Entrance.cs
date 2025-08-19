using System.Collections;

public class Entrance : IEnumerable
{
    private readonly Flat[] flats;

    public Entrance(Flat[] _flats) => flats = _flats;
    public IEnumerator GetEnumerator() => new EntranceEnumerator(flats);
}