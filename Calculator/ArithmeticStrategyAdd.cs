namespace Calculator;

public class ArithmeticStrategyAdd : IArithmeticStrategy
{
    public double Execute(double a, double b)
    {
        return a + b;
    }
    
}