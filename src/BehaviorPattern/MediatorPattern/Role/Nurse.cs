namespace BehaviorPattern.MediatorPattern.Role;

public class Nurse : RoleBase
{
    public Nurse(Mediator mediator) : base(mediator)
    {
    }

    public override void Doing()
    {
        Console.WriteLine("护士在检查");
    }
}