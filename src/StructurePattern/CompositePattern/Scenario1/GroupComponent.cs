namespace StructurePattern.CompositePattern.Scenario1;

public abstract class GroupComponent
{
    public virtual void Add(GroupComponent component)
    {
        throw new NotSupportedException();
    }

    public virtual void Remove(GroupComponent component)
    {
        throw new NotSupportedException();
    }

    public virtual GroupComponent GetChild(int index)
    {
        throw new NotSupportedException();
    }

    public abstract string Name { get; }
    
    public abstract string Code { get; }

    public virtual void Operation()
    {
        throw new NotSupportedException();
    }
}