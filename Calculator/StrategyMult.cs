namespace Calculator;

public class StrategyMult : IStrategy
{
    public double Execute(double a, double b)
    {
        return a * b;
    }
}