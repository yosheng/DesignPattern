namespace BehaviorPattern.TemplateMethodPattern;

public class Doctor : User
{
    public Doctor(string name) : base(name)
    {
    }

    protected override void CheckWork()
    {
        Console.WriteLine($"{Name}医生检查工作");
    }
}