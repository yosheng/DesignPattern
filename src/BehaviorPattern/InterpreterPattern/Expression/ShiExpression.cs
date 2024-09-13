namespace BehaviorPattern.InterpreterPattern.Expression;

public class ShiExpression : ExpressionBase
{
    public override string Unit()
    {
        return "十";
    }

    public override int Multiplier()
    {
        return 10;
    }
}