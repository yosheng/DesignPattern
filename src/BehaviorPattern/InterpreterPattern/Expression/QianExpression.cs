namespace BehaviorPattern.InterpreterPattern.Expression;

public class QianExpression : ExpressionBase
{
    public override string Unit()
    {
        return "千";
    }

    public override int Multiplier()
    {
        return 1000;
    }
}