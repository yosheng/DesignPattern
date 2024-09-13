using StructurePattern.BridgePattern.Sender;

namespace StructurePattern.BridgePattern.User;

public class CompanyUser : User
{
    public CompanyUser(ISender sender) : base(sender)
    {
    }

    public override void SendMessage(string message)
    {
        Console.WriteLine("企业发送消息");
        Sender.SendMessage(message);
    }
}