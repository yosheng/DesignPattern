namespace BehaviorPattern.IteratorPattern;

public interface IIterator
{
    void Next();

    bool IsLast();
    
    object CurrentItem();
}