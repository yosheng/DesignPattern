namespace BehaviorPattern.InterpreterPattern;

public abstract class ExpressionBase
{
    protected Dictionary<string, int> table = new Dictionary<string, int>();

    protected ExpressionBase()
    {
        table.Add("一", 1);
        table.Add("二", 2);
        table.Add("三", 3);
        table.Add("四", 4);
        table.Add("五", 5);
        table.Add("六", 6);
        table.Add("七", 7);
        table.Add("八", 8);
        table.Add("九", 9);
    }

    public virtual void Interpreter(ChineseNumberContext chineseNumberContext)
    {
        if (chineseNumberContext.Text.Length == 0)
        {
            return;
        }

        foreach (var key in table.Keys)
        {
            var value = table[key];

            if (chineseNumberContext.Text.EndsWith(key + Unit()))
            {
                chineseNumberContext.Amount += value * Multiplier();
                chineseNumberContext.Text = chineseNumberContext.Text.Remove(chineseNumberContext.Text.Length - (key.Length + Unit().Length));
            }

            if (chineseNumberContext.Text.EndsWith("零"))
            {
                chineseNumberContext.Text = chineseNumberContext.Text.Remove(chineseNumberContext.Text.Length - 1);
            }
        }
    }

    public abstract string Unit();

    public abstract int Multiplier();
}