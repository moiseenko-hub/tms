namespace Calculator;

public class StrategyContext
{
    private IArithmeticStrategy? _arithmeticStrategy;
    private IUnaryOperationStrategy _unaryOperationStrategy;

    public void SetStrategy(IArithmeticStrategy? arithmeticStrategy)
    {
        this._arithmeticStrategy = arithmeticStrategy;
    }

    public void SetStrategy(IUnaryOperationStrategy unaryOperationStrategy)
    {
        this._unaryOperationStrategy = unaryOperationStrategy;
    }

    public double ExecuteStrategy(double a, double b)
    {
        return this._arithmeticStrategy.Execute(a, b);
    }

    public double ExecuteStrategy(double a)
    {
        return this._unaryOperationStrategy.Execute(a);
    }
}