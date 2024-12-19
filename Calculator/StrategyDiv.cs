namespace Calculator;

public class StrategyDiv : IStrategy
{
    public double Execute(double a, double b)
    {
        return a - b;
    }
}