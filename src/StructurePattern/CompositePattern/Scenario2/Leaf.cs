namespace StructurePattern.CompositePattern.Scenario2;

public class Leaf : NodeComponent
{
    public Leaf(string name)
    {
        Name = name;
    }

    public override string Name { get; }

    public override void Display(int dept)
    {
        Console.WriteLine(new string('-', dept) + Name);
    }
}