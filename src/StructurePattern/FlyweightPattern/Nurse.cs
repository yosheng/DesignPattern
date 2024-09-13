namespace StructurePattern.FlyweightPattern;

public class Nurse : IRoleJob
{
    public void Working(string content)
    {
        Console.WriteLine($"护士正在执行:{content}");
    }
}