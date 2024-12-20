namespace Calculator;

public class ArithmeticStrategyMult : IArithmeticStrategy
{
    public double Execute(double a, double b)
    {
        return a * b;
    }
}