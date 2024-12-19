namespace Calculator;

public class StrategySub : IStrategy
{
    public double Execute(double a, double b)
    {
        return a / b;
    }
}