namespace BehaviorPattern.TemplateMethodPattern;

public abstract class User
{
    protected readonly string Name;

    protected User(string name)
    {
        Name = name;
    }
    
    protected abstract void CheckWork();
    
    public void GoOff()
    {
        CheckWork();
        Console.WriteLine($"{Name}下班了");
    }
}