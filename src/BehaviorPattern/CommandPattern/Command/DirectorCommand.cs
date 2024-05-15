using BehaviorPattern.CommandPattern.Receiver;

namespace BehaviorPattern.CommandPattern.Command;

public class DirectorCommand : ICommand
{
    private readonly DirectorReceiver _directorReceiver;

    public DirectorCommand(DirectorReceiver directorReceiver)
    {
        _directorReceiver = directorReceiver;
    }
    
    public void Execute()
    {
        _directorReceiver.Meeting();
    }
}