namespace StructurePattern.CompositePattern.Scenario1;

public class CompositeGroup : GroupComponent
{
    private List<GroupComponent> _children = new();

    public override string Name { get; }
    public override string Code { get; }

    public CompositeGroup(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public override void Add(GroupComponent component)
    {
        _children.Add(component);
    }
    
    public override void Remove(GroupComponent component)
    {
        _children.Remove(component);
    }

    public override GroupComponent GetChild(int index)
    {
        return _children.ElementAt(index);
    }

    public override void Operation()
    {
        Console.WriteLine($"{Name} - {Code} 查询用户中...");
        foreach (var groupComponent in _children)
        {
            groupComponent.Operation();
        }
    }
}