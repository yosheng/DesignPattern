using BehaviorPattern.StrategyPattern;
using BehaviorPattern.StrategyPattern.Strategy;
using Xunit.Abstractions;

namespace BehaviorPattern.Tests.StrategyPattern;

public class StrategyPatternTest : XunitContextBase
{
    public StrategyPatternTest(ITestOutputHelper output) : base(output)
    {
    }
    
    [Fact]
    public void Test()
    {
        var context = new PaymentContext("支付宝");
        context.Pay(100);
    }
    
    [Fact]
    public void Test2()
    {
        var context = new PaymentContext(new WechatStrategy());
        context.Pay(100);
    }
}