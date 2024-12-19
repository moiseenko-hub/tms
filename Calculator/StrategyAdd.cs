namespace Calculator;

public class StrategyAdd : IStrategy
{
    public double Execute(double a, double b)
    {
        return a + b;
    }
}