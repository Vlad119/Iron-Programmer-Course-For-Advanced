using System.Collections.Generic;

public class CarShowroom
{
    private readonly List<Car> cars;
    private int index = -1;
    public CarShowroom(List<Car> _cars) => cars = _cars;
    public CarShowroom GetEnumerator() => this;
    public Car Current => cars[index];

    public bool MoveNext()
    {
        index++;
        return index < cars.Count;
    }
    public void Reset() => index = -1;
}
