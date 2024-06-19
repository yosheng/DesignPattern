namespace BehaviorPattern.MediatorPattern.Role;

public class Doctor : RoleBase
{
    public Doctor(Mediator mediator) : base(mediator)
    {
    }

    public override void Doing()
    {
        Console.WriteLine("医生在检查");
    }
}