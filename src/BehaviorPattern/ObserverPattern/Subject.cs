namespace BehaviorPattern.ObserverPattern;

public abstract class Subject
{
    private List<IObserver> Observers { get; set; } = new();

    protected abstract string Name { get; }

    public void Register(IObserver observer)
    {
        Observers.Add(observer);
    }
    
    public void UnRegister(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in Observers)
        {
            observer.Notify($"{Name}通知 -> {message}");
        }
    }
}