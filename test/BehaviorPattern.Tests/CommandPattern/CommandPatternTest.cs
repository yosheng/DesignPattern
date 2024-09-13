using BehaviorPattern.CommandPattern;
using BehaviorPattern.CommandPattern.Command;
using BehaviorPattern.CommandPattern.Receiver;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.CommandPattern;

public class CommandPatternTest : XunitContextBase
{
    public CommandPatternTest(ITestOutputHelper output) : base(output)
    {
    }
    
    [Fact]
    public void Test()
    {
        var messageInvoker = new MessageInvoker();
        var doctorCommand = new DoctorCommand(new DoctorReceiver());
        var directorCommand = new DirectorCommand(new DirectorReceiver());
        
        messageInvoker.SetCommand(doctorCommand);
        messageInvoker.Execute();
        
        messageInvoker.SetCommand(directorCommand);
        messageInvoker.Execute();
    }
}