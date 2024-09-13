namespace BehaviorPattern.IteratorPattern;

public class PatientIterator : IIterator
{
    private Aggregate<Patient> Aggregate { get; }
    private int _positiveIndex;

    public PatientIterator(Aggregate<Patient> aggregate)
    {
        Aggregate = aggregate;
        _positiveIndex = 0;
    }

    public void Next()
    {
        if (_positiveIndex < Aggregate.Count)
        {
            _positiveIndex++;
        }
    }

    public bool IsLast()
    {
        return _positiveIndex == Aggregate.Count;
    }

    public object CurrentItem()
    {
        return Aggregate[_positiveIndex];
    }
}