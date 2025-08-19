using System.Collections;

public class Entrance : IEnumerable, IEnumerator
{
    private readonly Flat[] flats;
    private int currentIndex = -1;
    public object Current => flats[currentIndex];
    public Entrance(Flat[] _flats) => flats = _flats;

    public IEnumerator GetEnumerator() => this;

    public bool MoveNext()
    {
        currentIndex++;
        if (currentIndex >= flats.Length)
        {
            return false;
        }
        return true;
    }

    public void Reset() => currentIndex = -1;
}