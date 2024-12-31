namespace Calculator;

public class ArithmeticStrategyPercent : IArithmeticStrategy
{
    public double Execute(double a, double b)
    {
        return b * (a / 100);
    }
}