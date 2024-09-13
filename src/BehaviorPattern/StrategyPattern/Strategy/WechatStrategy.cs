namespace BehaviorPattern.StrategyPattern.Strategy;

public class WechatStrategy : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"微信支付{amount}元");
    }
}