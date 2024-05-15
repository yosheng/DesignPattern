using BehaviorPattern.CommandPattern.Command;

namespace BehaviorPattern.CommandPattern;

public class MessageInvoker
{
    private ICommand _command;
    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void Execute()
    {
        _command.Execute();
    }
}