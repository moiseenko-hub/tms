namespace Calculator;

public class ArithmeticStrategySub : IArithmeticStrategy
{
    public double Execute(double a, double b)
    {
        return a / b;
    }
}