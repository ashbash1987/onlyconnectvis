public class IntComponent : ValueComponent<int>
{
    public void Add(int amount)
    {
        Value += amount;
    }

    public void Minus(int amount)
    {
        Value -= amount;
    }
}
