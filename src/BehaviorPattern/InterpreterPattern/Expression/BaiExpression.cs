namespace BehaviorPattern.InterpreterPattern.Expression;

public class BaiExpression : ExpressionBase
{
    public override string Unit()
    {
        return "百";
    }

    public override int Multiplier()
    {
        return 100;
    }
}