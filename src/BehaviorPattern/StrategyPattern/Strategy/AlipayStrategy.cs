namespace BehaviorPattern.StrategyPattern.Strategy;

public class AlipayStrategy : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"支付宝支付{amount}元");
    }
}