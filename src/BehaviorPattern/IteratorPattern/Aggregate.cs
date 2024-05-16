namespace BehaviorPattern.IteratorPattern;

public abstract class Aggregate<T> where T : class
{
    private List<T> Data { get; }

    protected Aggregate(List<T> data)
    {
        Data = data;
    }
    
    public abstract IIterator CreateIterator();
    
    public int Count => Data.Count;
    
    public T this[int index] => Data[index];
}