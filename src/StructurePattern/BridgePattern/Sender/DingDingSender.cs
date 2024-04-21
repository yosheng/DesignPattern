namespace StructurePattern.BridgePattern.Sender;

public class DingDingSender : ISender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"发送钉钉消息:{message}");
    }
}