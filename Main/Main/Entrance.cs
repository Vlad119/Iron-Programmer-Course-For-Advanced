using System.Collections;
using System.Collections.Generic;

public class Entrance : IEnumerable<Flat>, IEnumerator<Flat>
{
    private readonly Flat[] flats;
    private int index = -1;
    public Entrance(Flat[] _flats) => flats = _flats;
    public Flat Current => flats[index];
    Flat IEnumerator<Flat>.Current => flats[index];

    object IEnumerator.Current => Current;

    IEnumerator IEnumerable.GetEnumerator() => this;
    IEnumerator<Flat> IEnumerable<Flat>.GetEnumerator() => this;

    public bool MoveNext()
    {
        index++;
        return index < flats.Length;
    }
    public void Reset() => index = -1;
    public void Dispose() { }
}
