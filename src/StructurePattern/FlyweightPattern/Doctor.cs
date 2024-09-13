namespace StructurePattern.FlyweightPattern;

/// <summary>
/// ConcreteFlyweight
/// </summary>
public class Doctor : IRoleJob
{
    public void Working(string content)
    {
        Console.WriteLine($"医生正在执行:{content}");
    }
}