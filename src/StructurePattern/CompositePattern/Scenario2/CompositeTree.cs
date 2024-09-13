namespace StructurePattern.CompositePattern.Scenario2;

public class CompositeTree : NodeComponent
{
    private List<NodeComponent> _nodeComponents = new();

    public CompositeTree(string name)
    {
        Name = name;
    }

    public override string Name { get; }

    public override void Display(int dept)
    {
        Console.WriteLine(new string('-', dept) + Name);
        foreach (var item in _nodeComponents)
        {
            item.Display(dept + 1);
        }
    }

    public void Add(NodeComponent component)
    {
        _nodeComponents.Add(component);
    }

    public void Remove(NodeComponent component)
    {
        _nodeComponents.Remove(component);
    }

    public NodeComponent GetChild(int index)
    {
        return _nodeComponents.ElementAt(index);
    }
}