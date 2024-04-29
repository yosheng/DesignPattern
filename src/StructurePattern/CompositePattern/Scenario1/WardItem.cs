namespace StructurePattern.CompositePattern.Scenario1;

public class WardItem : GroupComponent
{
    public override string Name { get; }
    public override string Code { get; }

    public WardItem(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public override void Operation()
    {
        Console.WriteLine($"{Name} - {Code} 查询病区用户中...");
    }
}