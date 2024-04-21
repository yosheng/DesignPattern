namespace StructurePattern.AdapterPattern.Scenario2.User;

public abstract class User
{
    protected ISender Sender;

    protected User(ISender sender)
    {
        Sender = sender;
    }

    public abstract void SendMessage(string message);
}