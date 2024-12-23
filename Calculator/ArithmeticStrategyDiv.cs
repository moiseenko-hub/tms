namespace Calculator;

public class ArithmeticStrategyDiv : IArithmeticStrategy
{
    public double Execute(double a, double b)
    {
        return a - b;
    }
}