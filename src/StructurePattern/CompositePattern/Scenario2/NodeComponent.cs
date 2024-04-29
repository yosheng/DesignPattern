namespace StructurePattern.CompositePattern.Scenario2;

public abstract class NodeComponent
{
    public abstract string Name { get; }
    
    public abstract void Display(int dept);
}