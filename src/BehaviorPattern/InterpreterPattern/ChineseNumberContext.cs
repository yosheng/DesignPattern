namespace BehaviorPattern.InterpreterPattern;

public class ChineseNumberContext
{
    public string Text { get; set; }

    public int Amount { get; set; }

    public ChineseNumberContext(string text)
    {
        Text = text;
    }
}