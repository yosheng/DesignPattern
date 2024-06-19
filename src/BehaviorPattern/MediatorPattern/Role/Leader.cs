namespace BehaviorPattern.MediatorPattern.Role;

public class Leader : RoleBase
{
    public Leader(Mediator mediator) : base(mediator)
    {
    }

    public override void Doing()
    {
        Console.WriteLine("领导开始工作");
    }
}