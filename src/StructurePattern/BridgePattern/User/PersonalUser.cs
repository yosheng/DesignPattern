using StructurePattern.BridgePattern.Sender;

namespace StructurePattern.BridgePattern.User;

public class PersonalUser : User
{
    public PersonalUser(ISender sender) : base(sender)
    {
    }

    public override void SendMessage(string message)
    {
        Console.WriteLine("个人发送消息");
        Sender.SendMessage(message);
    }
}