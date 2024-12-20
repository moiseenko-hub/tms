namespace Calculator;

public class StrategySquareRoot : IUnaryOperationStrategy
{
    public double Execute(double a)
    {
        return Math.Sqrt(a);
    }
}