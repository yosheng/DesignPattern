using System.Collections;

namespace BehaviorPattern.InterpreterPattern.Expression;

public class WanExpression : ExpressionBase
{
    public override string Unit()
    {
        return "万";
    }

    public override int Multiplier()
    {
        return 10000;
    }

    public override void Interpreter(ChineseNumberContext chineseNumberContext)
    {
        if (chineseNumberContext.Text.Length == 0)
        {
            return;
        }

        var arrayList = new List<ExpressionBase>
        {
            new GeExpression(),
            new ShiExpression(),
            new BaiExpression(),
            new QianExpression()
        };

        foreach (var key in table.Keys)
        {
            if (chineseNumberContext.Text.EndsWith(Unit()))
            {
                var temp = chineseNumberContext.Amount;
                chineseNumberContext.Amount = 0;
                
                chineseNumberContext.Text = chineseNumberContext.Text.Remove(chineseNumberContext.Text.Length - Unit().Length);
                
                foreach (var expression in arrayList)
                {
                    expression.Interpreter(chineseNumberContext);
                }
                
                chineseNumberContext.Amount = temp + chineseNumberContext.Amount * Multiplier();
            }
        }
    }
}