namespace BehaviorPattern.MediatorPattern;

public abstract class RoleBase
{
    protected Mediator _mediator;

    protected RoleBase(Mediator mediator)
    {
        _mediator = mediator;
    }
    
    public void Prepare()
    {
        _mediator.Prepare(this);
    }

    public abstract void Doing();
}