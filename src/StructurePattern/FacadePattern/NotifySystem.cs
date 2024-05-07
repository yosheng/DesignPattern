namespace StructurePattern.FacadePattern;

public class NotifySystem
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"发送通知: {message}");
    }
}