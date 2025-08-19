using System.Collections;

public class EntranceEnumerator : IEnumerator
{
    private readonly Flat[] flats;
    private int currentIndex = -1;

    public EntranceEnumerator(Flat[] _flats) => flats = _flats;
    public object Current => flats[currentIndex];

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