namespace BehaviorPattern.TemplateMethodPattern;

public class Nurse : User
{
    public Nurse(string name) : base(name)
    {
    }

    protected override void CheckWork()
    {
        Console.WriteLine($"{Name}检查护士工作");
    }
}