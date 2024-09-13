using BehaviorPattern.StrategyPattern.Strategy;

namespace BehaviorPattern.StrategyPattern;

public class PaymentContext
{
    private readonly IPaymentStrategy _paymentStrategy;

    public PaymentContext(string type)
    {
        _paymentStrategy = type switch
        {
            "支付宝" => new AlipayStrategy(),
            "微信" => new WechatStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Pay(double amount)
    {
        _paymentStrategy.Pay(amount);
    }
}