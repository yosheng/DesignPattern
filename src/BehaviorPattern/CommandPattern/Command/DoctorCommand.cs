using BehaviorPattern.CommandPattern.Receiver;

namespace BehaviorPattern.CommandPattern.Command;

public class DoctorCommand : ICommand
{
    private readonly DoctorReceiver _doctorReceiver;

    public DoctorCommand(DoctorReceiver doctorReceiver)
    {
        _doctorReceiver = doctorReceiver;
    }

    public void Execute()
    {
        _doctorReceiver.Work();
    }
}