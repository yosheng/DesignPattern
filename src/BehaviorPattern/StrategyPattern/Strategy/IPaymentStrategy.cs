namespace BehaviorPattern.StrategyPattern.Strategy;

public interface IPaymentStrategy
{
    void Pay(double amount);
}