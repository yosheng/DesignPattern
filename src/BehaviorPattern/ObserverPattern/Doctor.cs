namespace BehaviorPattern.ObserverPattern;

public class Doctor : IObserver
{
    public void Notify(string message)
    {
        Console.WriteLine($"医生收到消息:{message}");
    }
}