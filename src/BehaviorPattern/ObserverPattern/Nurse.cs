namespace BehaviorPattern.ObserverPattern;

public class Nurse : IObserver
{
    public void Notify(string message)
    {
        Console.WriteLine($"护士收到消息:{message}");
    }
}