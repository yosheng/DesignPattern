using StructurePattern.BridgePattern.Sender;

namespace StructurePattern.BridgePattern.User;

public abstract class User
{
    protected readonly ISender Sender;

    protected User(ISender sender)
    {
        Sender = sender;
    }

    public abstract void SendMessage(string message);
}