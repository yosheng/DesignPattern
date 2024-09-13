using System.Collections.Generic;
using BehaviorPattern.InterpreterPattern;
using BehaviorPattern.InterpreterPattern.Expression;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.InterpreterPattern;

public class InterpreterPatternTest : XunitContextBase
{
    public InterpreterPatternTest(ITestOutputHelper output) : base(output)
    {
    }
    
    [Fact]
    public void Test()
    {
        var context = new ChineseNumberContext("一亿三千三百二十一万八千三百五十六");

        var expressionBases = new List<ExpressionBase>();
        expressionBases.Add(new GeExpression());
        expressionBases.Add(new ShiExpression());
        expressionBases.Add(new BaiExpression());
        expressionBases.Add(new QianExpression());  
        expressionBases.Add(new WanExpression());
        expressionBases.Add(new YiExpression());    
        expressionBases.ForEach(expressionBase => expressionBase.Interpreter(context)); 
        
        Output.WriteLine(context.Amount.ToString());
        
        Output.WriteLine(context.Text);
    }
}