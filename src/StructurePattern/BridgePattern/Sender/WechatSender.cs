namespace StructurePattern.BridgePattern.Sender;

public class WechatSender : ISender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"发送微信消息:{message}");
    }
}