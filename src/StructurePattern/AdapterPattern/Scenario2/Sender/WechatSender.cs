namespace StructurePattern.AdapterPattern.Scenario2;

public class WechatSender : ISender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"发送微信消息:{message}");
    }
}