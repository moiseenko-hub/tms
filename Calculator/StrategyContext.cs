namespace Calculator;

public class StrategyContext
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        this._strategy = strategy;
    }

    public double ExecuteStrategy(double a, double b)
    {
        return this._strategy.Execute(a, b);
    }
}